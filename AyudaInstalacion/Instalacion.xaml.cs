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
    /// Interaction logic for Instalacion.xaml
    /// </summary>
    public partial class Instalacion : Window
    {
        public Instalacion()
        {
            InitializeComponent();
            
            
        }
        private delegate void UpdateProgressBarDelegate(System.Windows.DependencyProperty dp, Object value);
        private void Process()
        {
            
            progressBar1.Minimum = 0;
            progressBar1.Maximum = short.MaxValue;
            progressBar1.Value = 0;

            
            double value = 0;

           UpdateProgressBarDelegate updatePbDelegate = new UpdateProgressBarDelegate(progressBar1.SetValue);

            
            do
            {
                value += 6;

                Dispatcher.Invoke(updatePbDelegate,
                    System.Windows.Threading.DispatcherPriority.Background,
                    new object[] { ProgressBar.ValueProperty, value });

            }
            while (progressBar1.Value != progressBar1.Maximum);
            label2.Content = "The installation was successful";
            button1.Content = "Finish";
            button2.IsEnabled = false;
            button3.IsEnabled = false;

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (button1.Content == "Finish")
            {
                this.Owner.Close();
                this.Close();
            }
            else
            {
                progressBar1.IsEnabled = true;
                Process();
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            
            this.Owner.Close();
            this.Close();
        }

        
    }
}
