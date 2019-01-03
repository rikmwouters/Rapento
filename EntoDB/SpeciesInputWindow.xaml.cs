using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;

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

        private void CoolTabButton_Click(object sender, RoutedEventArgs e)
        {
            //TabItem ti = Tabs1.SelectedItem.AsTabItem();
            //MessageBox.Show("This is " + ti.Header + " tab");
        }

        private void SelectImageButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opDialog = new OpenFileDialog();
        }

        private void SpecimenInputSubmitButton_Click(object sender, RoutedEventArgs e)
        {
            DataAccess data = new DataAccess();
            data.AddIndividual(GenusBox.Text, SpeciesBox.Text, CollectionBox.Text);

            GenusBox.Text = "";
            SpeciesBox.Text = "";
            CollectionBox.Text = "";
            LocalityBox.Text = "";
            SamplingDateBox.SelectedDate = null;
        }
    }
}
