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

namespace Zeus.forms
{
    /// <summary>
    /// Interaktionslogik für overview.xaml
    /// </summary>
    public partial class overview : Window
    {
        public overview()
        {
            InitializeComponent();
        }

        private void Mi_close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Mi_logout(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();  
            this.Close();
        }
    }
}
