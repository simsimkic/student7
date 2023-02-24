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

namespace HospitalApplication.UI.HospitalManagerUI
{
    /// <summary>
    /// Interaction logic for HMMenu.xaml
    /// </summary>
    public partial class HMMenu : Window
    {
        public HMMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HMZaposleni hMZaposleni = new HMZaposleni();
            hMZaposleni.Top = this.Top;
            hMZaposleni.Left = this.Left;
            hMZaposleni.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HospitalManagerMainWindow hMMainWindow = new HospitalManagerMainWindow();
            hMMainWindow.Top = this.Top;
            hMMainWindow.Left = this.Left;
            hMMainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HMLekovi hMLekovi = new HMLekovi();
            hMLekovi.Top = this.Top;
            hMLekovi.Left = this.Left;
            hMLekovi.Show();
            this.Close();
        }
    }
}
