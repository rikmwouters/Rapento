
using System.Windows;

namespace Rapento
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

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OpenSpecimenInput_Click(object sender, RoutedEventArgs e)
        {
            new SpecimenInputWindow().Show();
        }

        private void FindTaxonID_Click(object sender, RoutedEventArgs e)
        {
            new FindTaxonIDWindow().Show();
        }
    }
}
