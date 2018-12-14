using Microsoft.Win32;
using System.Windows;


namespace Rapento
{
    /// <summary>
    /// Interaction logic for SpecimenInputWindow.xaml
    /// </summary>
    public partial class SpecimenInputWindow : Window
    {
        public SpecimenInputWindow()
        {
            InitializeComponent();
        }

        private void SelectImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
        }

        private void SpecimenInputSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess data = new DataAccess();
            data.AddIndividual(GenusBox.Text, SpeciesBox.Text);

            GenusBox.Text = "";
            SpeciesBox.Text = "";
            CollectionBox.Text = "";
            LocalityBox.Text = "";
            SamplingDateBox.Text = "";
        }
    }
}
