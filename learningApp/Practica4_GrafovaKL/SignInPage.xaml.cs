using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Window
    {

        Data.ApplicationContext application = new Data.ApplicationContext();
        public SignInPage()
        {
           
            InitializeComponent();
            ShowInTaskbar =false;
            
            application.DbUsers.Load();

        }
     

       

        private void Login_TextChanged(object sender, TextChangedEventArgs e)

        {
            
                HintLogin.Visibility = Visibility.Hidden;
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
        }

        private void ButtonPass_Click(object sender, RoutedEventArgs e)
        {
            
            if (TextShowPassword.Visibility==Visibility.Visible)
            {
                if(Password.Password==string.Empty) HintPassword.Visibility = Visibility.Visible;
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
                Password.Visibility=Visibility.Hidden;
                TextShowPassword.Visibility = Visibility.Visible;

            }
                

        }
        

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            Registration registration=new Registration();
            registration.ShowDialog();
            Close();
            
            
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            User user1 = new User { Login = Login.Text, Password = Password.Password };

            foreach (User user in application.DbUsers)
            {
                if (user.Login == user1.Login && (user.Password == user1.Password ))
                {
                    MainWindow.activeUser = user;
                    Close();

                    return;
                }
                else if(user.Login == user1.Login && (user.Password != user1.Password))
                {

                    System.Windows.Forms.MessageBox.Show("Неверный пароль", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;


                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Такого пользователя не существует", "Ошибка",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }

            }
            

        }

        private void TextShowPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            HintPassword.Visibility=Visibility.Hidden;
        }

        private void TextShowPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (TextShowPassword.Text == string.Empty)
            {
                Password.Password=TextShowPassword.Text;
                TextShowPassword.Visibility=Visibility.Hidden;
                Password.Visibility=Visibility.Visible;
                HintPassword.Visibility=Visibility.Visible;
                PassowordShowOrHide.Content = FindResource("Show");
            }
                

        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
