using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace HospitalApplication.UI
{
    /// <summary>
    /// Interaction logic for SelectionMenu.xaml
    /// </summary>
    public partial class SelectionMenu : Window
    {

        private bool back = true;
        public SelectionMenu()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            if(back) System.Windows.Application.Current.MainWindow.Show();
        }

        private void hospitalManager_btn_Click(object sender, RoutedEventArgs e)
        {
            UI.HospitalManagerUI.HospitalManagerMainWindow HMMainWindow = new UI.HospitalManagerUI.HospitalManagerMainWindow();
            back = false;
            this.Close();
            HMMainWindow.Show();
        }

        private void patient_btn_Click(object sender, RoutedEventArgs e)
        {
            UI.PatientUI.PatientMainWindow PMainWindow = new UI.PatientUI.PatientMainWindow();
            back = false;
            this.Close();
            PMainWindow.Show();
        }

        private void doctor_btn_Click(object sender, RoutedEventArgs e)
        {
            UI.DoctorUI.DoctorMainWindow doctorMainWindow = new UI.DoctorUI.DoctorMainWindow();
            back = false;
            this.Close();
            doctorMainWindow.Show();
        }

        private void secretary_btn_Click(object sender, RoutedEventArgs e)
        {
            UI.SecretaryUI.SecretaryMainWindow SMainWindow = new UI.SecretaryUI.SecretaryMainWindow();
            back = false;
            this.Close();
            SMainWindow.Show();
        }
    }
}
