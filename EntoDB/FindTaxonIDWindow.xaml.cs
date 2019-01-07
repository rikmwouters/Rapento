
using System.Windows;
using Rapento;

namespace Rapento
{
    /// <summary>
    /// Interaction logic for FindTaxonID.xaml
    /// </summary>
    public partial class FindTaxonIDWindow : Window
    {
        public FindTaxonIDWindow()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess data = new DataAccess();
            var result = data.FindTaxonID(TaxonNameBox.Text).ToString();

            TaxonNameBox.Text = "";
            ResultLabel.Content = result;
        }
    }
}
