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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.home = this;
            this.NavigationService.Navigate(MainWindow.inputform);
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            //create the new tab
            //for swipe betwen two tabs in home and form
            TextBox newtab = (TextBox)sender;
            newtab.Text = string.Empty;
            newtab.GotFocus -= TextBox_GotFocus;
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MainWindow.home = this;
            tabctr.SelectedIndex = 0;
            this.NavigationService.Navigate(MainWindow.inputform);
        }


    }
}
