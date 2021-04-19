using System;
using System.Collections.Generic;
using System.Windows;
using ReportingEngine.Constants;

namespace ReportingEngine.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<string> headers = new List<string>
            {
                "نام",
                "پتہ",
                "شھر",
            };

            ReportingGenerator reportingGenerator = new ReportingGenerator();
            //reportingGenerator.GenerateReport(new Repository().GetData(), "My Report", DateTime.Now, "Hussain", PageSize.A4, Orientation.Vertical);
            reportingGenerator.GenerateReport(new Repository().GetData(), "میرا رپورٹ", DateTime.Now, "حسین", PageSize.A4, Orientation.Vertical, "رپورٹ نام", "رپورٹ تاریخ", "بنانے والا", headers);

        }
    }
}
