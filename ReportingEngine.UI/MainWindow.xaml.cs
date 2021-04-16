using System;
using System.Windows;

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
            ReportingGenerator reportingGenerator = new ReportingGenerator();
            reportingGenerator.GenerateReport(new Repository().GetData(),"My Report", DateTime.Now, "Hussain");
        }
    }
}
