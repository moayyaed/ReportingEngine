using Microsoft.Win32;
using ReportingEngine.Constants;
using ReportingEngine.Usages;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Xps.Packaging;
using System.Windows.Xps.Serialization;

namespace ReportingEngine
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        #region Initialize

        public ReportWindow()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        public DataTable ReportRawData { get; set; }
        public DateTime? ReportCreationDate { get; set; }
        public string ReportName { get; set; }
        public string ReportCreator { get; set; }
        public string ReportCreationDateLabel { get; set; }
        public string ReportNameLabel { get; set; }
        public string ReportCreatorLabel { get; set; }
        public List<string> ReportHeaders { get; set; }
        public PageSize PageSize { get; set; }
        public Orientation Orientation { get; set; }


        #endregion

        #region Only Number Validation

        private void PageNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        #endregion

        #region Report Window Activation

        private bool _firstActivated = true;
        XpsDocument xpsDoc;
        private void Window_Activated(object sender, EventArgs e)
        {
            if (!_firstActivated) return;

            _firstActivated = false;

            Dispatcher.BeginInvoke(DispatcherPriority.ApplicationIdle, new Action(delegate
            {
                try
                {
                    ReportDocument reportDocument = new ReportDocument();
                    StreamReader reader = new StreamReader(new FileStream(@"Templates\ReportFormat.xaml", FileMode.Open, FileAccess.Read));
                    reportDocument.XamlData = reader.ReadToEnd();
                    reportDocument.XamlImagePath = Path.Combine(Environment.CurrentDirectory, @"Templates\");
                    reader.Close();

                    ReportData data = new ReportData();

                    //Report Information
                    DataTable reportInformationTable = new DataTable("ReportInformation");
                    reportInformationTable.Columns.Add("CreationDate");
                    reportInformationTable.Columns.Add("Name");
                    reportInformationTable.Columns.Add("CreatedBy");
                    reportInformationTable.Rows.Add(new object[] { (ReportCreationDate ?? DateTime.Now).ToString("dd-MM-yyyy"), ReportName ?? "NA", ReportCreator ?? "NA" });
                    data.DataTables.Add(reportInformationTable);


                    //Report Information headers
                    DataTable reportInformationHeadersTable = new DataTable("ReportInformationHeaders");
                    reportInformationHeadersTable.Columns.AddRange(new DataColumn[] { new DataColumn("ReportCreationDateLabel"), new DataColumn("ReportNameLabel"), new DataColumn("ReportCreatorLabel") });
                    reportInformationHeadersTable.Rows.Add(new object[] { ReportCreationDateLabel ?? "Report Creation Date", ReportNameLabel ?? "Report Name", ReportCreatorLabel ?? "Report Creator" });
                    data.DataTables.Add(reportInformationHeadersTable);

                    //Report Headers and Report Data
                    DataTable reportHeadersTable = new DataTable("ReportHeaders");
                    DataTable reportDataTable = ReportRawData;
                    reportDataTable.TableName = "ReportData";
                    reportHeadersTable.Columns.Add();
                    foreach (var header in ReportHeaders ?? ReportRawData.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToList())
                    {
                        reportHeadersTable.Rows.Add(header);
                    }
                    data.DataTables.Add(reportHeadersTable);
                    data.DataTables.Add(reportDataTable);

                    //Set Page Sizing
                    SetPageSizing(reportDocument);

                    //Generate Report
                    XpsDocument xps = reportDocument.CreateXpsDocument(data);
                    xpsDoc = reportDocument.CreateXpsDocument(data);
                    documentViewer.Document = xps.GetFixedDocumentSequence();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n\r\n" + ex.GetType() + "\r\n" + ex.StackTrace, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                finally
                {
                    busyDecorator.IsBusyIndicatorHidden = true;
                }
            }));
        }

        #endregion

        #region Page Sizing and Orientation

        void SetPageSizing(ReportDocument reportDocument)
        {
            switch (PageSize)
            {
                case PageSize.A4:
                    switch (Orientation)
                    {
                        case Orientation.Vertical:
                            reportDocument.PageHeight = CentimeterToPixel(29.7);
                            reportDocument.PageWidth = reportDocument.ColumnWidth = CentimeterToPixel(21);
                            break;
                        case Orientation.Horizontal:
                            reportDocument.PageHeight = CentimeterToPixel(21);
                            reportDocument.PageWidth = reportDocument.ColumnWidth = CentimeterToPixel(29.7);
                            break;
                    }
                    break;
                case PageSize.A5:
                    switch (Orientation)
                    {
                        case Orientation.Vertical:
                            reportDocument.PageHeight = CentimeterToPixel(21);
                            reportDocument.PageWidth = reportDocument.ColumnWidth = CentimeterToPixel(14.8);
                            break;
                        case Orientation.Horizontal:
                            reportDocument.PageHeight = CentimeterToPixel(14.8);
                            reportDocument.PageWidth = reportDocument.ColumnWidth = CentimeterToPixel(21);
                            break;
                    }
                    break;
                default:
                    break;
            }


        }

        #endregion

        #region Centimeter to Pixel Converter

        double CentimeterToPixel(double centimeter)
        {
            return centimeter * 37.7952755905512;
        }

        #endregion

        #region PDF Generation

        private void PDF_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Title = "Save as PDF",
                    DefaultExt = "pdf",
                    Filter = "Pdf Files|*.pdf",
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    GeneratePDFFile(saveFileDialog.FileName);
                    MessageBox.Show($"PDF File saved at {saveFileDialog.FileName}", "PDF File Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error in PDF generation", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GeneratePDFFile(string pdfOutputPath)
        {

            var memoryStream = new MemoryStream();
            XpsSerializerFactory serializerFactory = new XpsSerializerFactory();
            SerializerWriter serializerWriter = serializerFactory.CreateSerializerWriter(memoryStream);
            serializerWriter.Write(xpsDoc.GetFixedDocumentSequence());
            var bytes = memoryStream.ToArray();

            // Print to PDF
            PdfFilePrinter.PrintXpsToPdf(bytes, pdfOutputPath, "Document title");
        }

        #endregion

        #region CSV Generation

        private void CSV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var saveFileDialog = new SaveFileDialog
                {
                    Title = "Save as CSV",
                    DefaultExt = "csv",
                    Filter = "CSV file (*.csv)|*.csv"
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    GenerateCSVFile(saveFileDialog.FileName);
                    MessageBox.Show($"CSV File saved at {saveFileDialog.FileName}", "CSV File Saved", MessageBoxButton.OK, MessageBoxImage.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error in PDF generation", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void GenerateCSVFile(string csvOutputPath)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = ReportRawData.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in ReportRawData.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => string.Concat("\"", field.ToString().Replace("\"", "\"\""), "\""));
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(csvOutputPath, sb.ToString());
        }

        #endregion
    }
}
