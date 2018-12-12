using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
    }
}
