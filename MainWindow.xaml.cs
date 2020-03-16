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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quete2_XAML_ListBox
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (InputTextZone.Text == "")
            {
                MessageBox.Show("You need to put a name.");
            }
            if (listBox1.Items.Contains(InputTextZone.Text))
            {
                MessageBox.Show("This name already exists.");
            }
            else
            {
                listBox1.Items.Add(InputTextZone.Text);
            }           
                       
        }
    }
}
