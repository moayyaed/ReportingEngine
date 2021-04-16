using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Windows;

namespace ReportingEngine
{
    public class ReportingGenerator
    {
        public void GenerateReport(DataTable data, string name, DateTime creationDate, string creator)
        {
            try
            {
                //ReportWindow reportWindow = new ReportWindow { report}
                ReportWindow reportWindow = new ReportWindow
                {
                    ReportRawData = data,
                    ReportName = name,
                    ReportCreationDate = creationDate,
                    ReportCreator = creator
                };
                reportWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
