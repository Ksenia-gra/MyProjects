using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        internal ProfilePage()
        {
            InitializeComponent();
            Login.Text = MainWindow.activeUser.Login;

            Email.Text = MainWindow.activeUser.Email;
            TestResult.Text = TestPage.result.ToString()+"/"+"15";
            TestResult.TextAlignment=TextAlignment.Center;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.Forms.MessageBox.Show("Закрыть?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                System.Windows.Application.Current.Shutdown();
                System.Windows.Forms.Application.Restart();
            }

            else
                return;

        }
    }
}
