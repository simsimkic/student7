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

namespace HospitalApplication.UI.SecretaryUI
{
    /// <summary>
    /// Interaction logic for SecretaryMainWindow.xaml
    /// </summary>
    public partial class SecretaryMainWindow : Window
    {
        public SecretaryMainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LOGIN_btn_Click(object sender, RoutedEventArgs e)
        {
            UI.SecretaryUI.HomeSecretary homeSecretary = new UI.SecretaryUI.HomeSecretary();
            this.Hide();
            homeSecretary.Show();

        }

        

       private void helper_btn_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(help1);
        }
        public void SetActiveUserControl(UserControl control)
        {
            help1.Visibility = Visibility.Collapsed;

            control.Visibility = Visibility.Visible;
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        /* private void helper_btn_click(object sender, RoutedEventArgs e)
{
UI.SecretaryUI.SecretaryMainWindowHelpers helpers = new UI.SecretaryUI.SecretaryMainWindowHelpers();
this.Hide();
helpers.Show();

}*/
    }
}
