using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AyudaInstalacion
{
    /// <summary>
    /// Interaction logic for Terminos.xaml
    /// </summary>
    public partial class Terminos : Window
    {
        public Terminos()
        {
            InitializeComponent();
            
            scrollViewer1.Content = System.IO.File.ReadAllText("TerminosServicios.txt");
            
            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            if (radioButton1.IsChecked == true)
            {
                
                Instalacion install = new Instalacion();
                install.Owner = this;
                install.Show();

            }
            
            
        }

        
    }
}
