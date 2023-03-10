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
    /// Interaction logic for MyProfile.xaml
    /// </summary>
    public partial class MyProfile : Window
    {
        public MyProfile()
        {
            InitializeComponent();
        }
        private void Home_button_click(object sender, RoutedEventArgs e)
        {
            UI.SecretaryUI.HomeSecretary home = new UI.SecretaryUI.HomeSecretary();
            this.Hide();
            home.Show();
        }
        private void My_profile_btn(object sender, RoutedEventArgs e)
        {
            UI.SecretaryUI.MyProfile profile = new UI.SecretaryUI.MyProfile();
            this.Hide();
            profile.Show();
        }
    }
}
