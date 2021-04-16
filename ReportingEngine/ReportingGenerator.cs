using System;
using System.Data;
using System.Windows;

namespace ReportingEngine
{
    public class ReportingGenerator
    {
        public void GenerateReport(DataTable reportData, string reportName, DateTime creationDate, string creator)
        {
            try
            {
                ReportWindow reportWindow = new ReportWindow(reportData);
                reportWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
