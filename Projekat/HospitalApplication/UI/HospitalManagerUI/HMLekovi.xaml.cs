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
    /// Interaction logic for HMLekovi.xaml
    /// </summary>
    public partial class HMLekovi : Window
    {
        public HMLekovi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HospitalManagerMainWindow hMMainWindow = new HospitalManagerMainWindow();
            hMMainWindow.Top = this.Top;
            hMMainWindow.Left = this.Left;
            hMMainWindow.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HMMenu hMMenu = new HMMenu();
            hMMenu.Top = this.Top;
            hMMenu.Left = this.Left;
            hMMenu.Show();
            this.Close();
        }
    }
}
