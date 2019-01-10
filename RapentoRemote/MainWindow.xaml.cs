using System.Net.Http;
using System.Text;
using System.Windows;

namespace RapentoRemote
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

        private async void FindTaxonIDButton_Click(object sender, RoutedEventArgs e)
        {
            string myJson = "{'GivenTaxonName': '" + TaxonNameBox.Text + "'}";
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("http://localhost:50683/api/Taxons/", 
                    new StringContent(myJson, Encoding.UTF8, "application/json"));
                FindTaxonIDResult.Text = response.ToString();
            }
        }
    }
}
