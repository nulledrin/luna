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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for Properties.xaml
    /// </summary>
    public partial class Propertiess : Window
    {
        public Propertiess()
        {
            InitializeComponent();
        }


        private void openmain(object sender, RoutedEventArgs e)
        {
            MainWindow mnw = new MainWindow();
            mnw.Owner = this;
            this.Hide(); // not required if using the child events below
            mnw.ShowDialog();
        }
    }
}
