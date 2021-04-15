using ReportingEngine.Usages;
using System;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using System.Windows.Xps.Packaging;

namespace ReportingEngine
{
    /// <summary>
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public DataTable ReportRawData { get; set; }
        
        public ReportWindow(DataTable reportRawData)
        {
            InitializeComponent();
            ReportRawData = reportRawData;
        }

        private void PageNumber_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }


        private bool _firstActivated = true;

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

                    DateTime dateTimeStart = DateTime.Now; // start time measure here

                    ReportData data = new ReportData();
                    DataTable reportInformation = new DataTable("ReportInformation");
                    reportInformation.Columns.Add("CreationDate");
                    reportInformation.Columns.Add("Name");
                    reportInformation.Columns.Add("CreatedBy");

                    reportInformation.Rows.Add(new object[] { DateTime.Now.ToString("dd-MM-yyyy"), "Test Name", "Hussain" });
                    data.DataTables.Add(reportInformation);

                    DataTable reportHeaders = new DataTable("ReportHeaders");
                    DataTable reportData = ReportRawData;
                    reportData.TableName = "ReportData";

                    reportHeaders.Columns.Add();
                    foreach (var col in ReportRawData.Columns)
                    {
                        reportHeaders.Rows.Add(new object[] { col.ToString() });
                    }
                    
                   
                    data.DataTables.Add(reportHeaders);
                    data.DataTables.Add(reportData);

                    XpsDocument xps = reportDocument.CreateXpsDocument(data);
                    documentViewer.Document = xps.GetFixedDocumentSequence();
                    
                    // show the elapsed time in window title
                    Title += " - generated in " + (DateTime.Now - dateTimeStart).TotalMilliseconds + "ms";
                }
                catch (Exception ex)
                {
                    // show exception
                    MessageBox.Show(ex.Message + "\r\n\r\n" + ex.GetType() + "\r\n" + ex.StackTrace, ex.GetType().ToString(), MessageBoxButton.OK, MessageBoxImage.Stop);
                }
                finally
                {
                    busyDecorator.IsBusyIndicatorHidden = true;
                }
            }));
        }
    }
}
