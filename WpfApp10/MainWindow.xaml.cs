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

namespace WpfApp10
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tab2ComboBox.SelectedIndex = tab1ComboBox.SelectedIndex;
            tab2ComboBox1.SelectedIndex = tab1ComboBox1.SelectedIndex;


        }
        private void tab1ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = tab1ComboBox.SelectedIndex;

            tab2ComboBox.SelectedIndex = selectedIndex;


        }

        private void tab1ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedIndex = tab1ComboBox.SelectedIndex;

            tab2ComboBox1.SelectedIndex = selectedIndex;


        }

    }
}
