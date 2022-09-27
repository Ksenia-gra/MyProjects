using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net.Mail;
using System.Data.Entity;
using Practica4_GrafovaKL.Data;
using System.Windows.Forms;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        Data.ApplicationContext application =new Data.ApplicationContext();
        public Registration()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Female.IsChecked = true;
            application.DbUsers.Load();
            
        }
        private void Email_TextChanged(object sender, TextChangedEventArgs e)

        {

            HintEmail.Visibility = Visibility.Hidden;
            if (!Registration.IsValidMailAddress1(email.Text) || !Registration.IsValidMailAddress2(email.Text))
            {
                email.BorderBrush = new SolidColorBrush(Colors.Red);
                email.BorderThickness = new Thickness(2);
                RegistrationButton.IsEnabled = false;

            }
            else
            {
                email.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
                email.BorderThickness = new Thickness(3);
                RegistrationButton.IsEnabled = true;
            }
        }

        private void Email_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm.@_".IndexOf(e.Text) < 0;
        }

        private void Email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (email.Text == string.Empty)
                HintEmail.Visibility = Visibility.Visible;
        }
        
        private void Login_TextChanged(object sender, TextChangedEventArgs e)

        {
           
            HintLogin.Visibility = Visibility.Hidden;
            Login.Text=Login.Text.Trim();
            if(Login.Text==string.Empty)
            {
                Login.BorderBrush = new SolidColorBrush(Colors.Red);
                Login.BorderThickness = new Thickness(2);
                RegistrationButton.IsEnabled = false;
            }
            else
            {
                Login.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
                Login.BorderThickness = new Thickness(3);
                RegistrationButton.IsEnabled = true;
            }
        }

        private void Login_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm.@_".IndexOf(e.Text) < 0;
        }

        private void Login_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Login.Text == string.Empty)
                HintLogin.Visibility = Visibility.Visible;
        }
        private void Password_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Password.Password == string.Empty)
            {
                HintPassword.Visibility = Visibility.Visible;

                PassowordShowOrHide.Content = FindResource("Show");
            }

        }

        private void Password_PasswordChanged(object sender, RoutedEventArgs e)
        {

            HintPassword.Visibility = Visibility.Hidden;
            
            if (Password.Password == string.Empty || (Password.Password.Length<6))
            {
                Password.BorderBrush = new SolidColorBrush(Colors.Red);
                Password.BorderThickness = new Thickness(2);
                RegistrationButton.IsEnabled = false;
            }
            else
            {
                Password.BorderBrush = new SolidColorBrush(Colors.LimeGreen);
                Password.BorderThickness = new Thickness(3);
                RegistrationButton.IsEnabled = true;
            }
        }

        private void ButtonPass_Click(object sender, RoutedEventArgs e)
        {

            if (TextShowPassword.Visibility == Visibility.Visible)
            {
                if (Password.Password == string.Empty) HintPassword.Visibility = Visibility.Visible;
                PassowordShowOrHide.Content = FindResource("Show");

                Password.Password = TextShowPassword.Text;
                Password.Visibility = Visibility.Visible;
                TextShowPassword.Visibility = Visibility.Hidden;



            }


            else
            {
                if (TextShowPassword.Text == string.Empty) HintPassword.Visibility = Visibility.Visible;
                PassowordShowOrHide.Content = Resources["Hide"];
                TextShowPassword.Text = Password.Password;
                Password.Visibility = Visibility.Hidden;
                TextShowPassword.Visibility = Visibility.Visible;


            }


        }


        
        

        private void TextShowPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            HintPassword.Visibility = Visibility.Hidden;
        }

        private void TextShowPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextShowPassword.Text == string.Empty)
            {
                Password.Password = TextShowPassword.Text;
                TextShowPassword.Visibility = Visibility.Hidden;
                Password.Visibility = Visibility.Visible;
                HintPassword.Visibility = Visibility.Visible;
                PassowordShowOrHide.Content = FindResource("Show");
            }


        }

        private void BackToSignIn_Click(object sender, RoutedEventArgs e)
        {
            SignInPage signInPage = new SignInPage();
            signInPage.ShowDialog();
            Close();
            
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {

            Male.IsChecked = false;
        }

        private void Male_Checked(object sender, RoutedEventArgs e)
        {
            Female.IsChecked=false;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            User user1 = new User { Login=Login.Text,Email=email.Text,Password=Password.Password};
           
            foreach (User user in application.DbUsers)
            {
                if (user.Login==user1.Login)
                {
                    System.Windows.Forms.MessageBox.Show("Такой пользователь уже существует\nПридумайте другой логин", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {

                    if (Female.IsChecked == true) user1.Gender = "Ж";
                    else user1.Gender = "М";
                    application.DbUsers.Add(user1);
                    application.SaveChanges();
                    MainWindow.activeUser = user1;
                    Close();

                    return;
                    
                }

            }


        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        static bool IsValidMailAddress1(string mail)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(mail);

                return true;
            }
            catch
            {
                return false;
            }
        }

        static bool IsValidMailAddress2(string mailAddress)
        {
            return Regex.IsMatch(mailAddress, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        private void Password_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm".IndexOf(e.Text) < 0;
        }
    }
}
