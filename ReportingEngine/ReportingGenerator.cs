using ReportingEngine.Constants;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace ReportingEngine
{
    public class ReportingGenerator
    {
        #region Generate Default Report

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">Report Data to be printed on report</param>
        /// <param name="name">Name of the report</param>
        /// <param name="creationDate">Date of creation of report</param>
        /// <param name="creator">Creator of report</param>
        public void GenerateReport(DataTable data, string name, DateTime creationDate, string creator, PageSize pageSize, Orientation orientation)
        {
            try
            {
                ReportWindow reportWindow = new ReportWindow
                {
                    ReportRawData = data,
                    ReportName = name,
                    ReportCreationDate = creationDate,
                    ReportCreator = creator,
                    PageSize = pageSize,
                    Orientation = orientation
                };
                reportWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion

        #region Generate Labeled Report

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data">Report Data to be printed on report</param>
        /// <param name="name">Name of the report</param>
        /// <param name="creationDate">Date of creation of report</param>
        /// <param name="creator">Creator of report</param>
        /// <param name="nameLabel">Report Name label</param>
        /// <param name="creationDateLabel">Report Creation Date Label</param>
        /// <param name="creatorLabel">Report Creator Label</param>
        public void GenerateReport(DataTable data, string name, DateTime creationDate, string creator, PageSize pageSize, Orientation orientation, string nameLabel, string creationDateLabel, string creatorLabel, List<string> reportHeaders)
        {
            try
            {
                ReportWindow reportWindow = new ReportWindow
                {
                    ReportRawData = data,
                    ReportName = name,
                    ReportCreationDate = creationDate,
                    ReportCreator = creator,
                    ReportNameLabel = nameLabel,
                    ReportCreationDateLabel = creationDateLabel,
                    ReportCreatorLabel = creatorLabel,
                    ReportHeaders = reportHeaders,
                    PageSize = pageSize,
                    Orientation = orientation
                };
                reportWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        #endregion
    
    }
}
