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

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для SplashScreen.xaml
    /// </summary>
    public partial class SplashScreen : Window
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        public void BeginButton_Click(object sender, RoutedEventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.ShowDialog();
            Close();
            
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);

        }
        
    }
}
