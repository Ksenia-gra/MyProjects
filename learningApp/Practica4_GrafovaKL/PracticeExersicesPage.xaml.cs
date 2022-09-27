using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для PracticeExersicesPage.xaml
    /// </summary>
    public partial class PracticeExersicesPage : Page
    {
        List<string> files = new List<string>();
        List<string>titles=new List<string>();
        System.Windows.Controls.TextBox textBox =new System.Windows.Controls.TextBox();
        System.Windows.Controls.TextBlock textBlock = new System.Windows.Controls.TextBlock();
        string rightAnswer = "";
        public PracticeExersicesPage()
        {
            InitializeComponent();
            
            files.Add(System.IO.Path.GetFullPath(@"..\..\Practice\Сущность права.txt"));
            files.Add(System.IO.Path.GetFullPath(@"..\..\Practice\Правовые нормы.txt"));
            files.Add(System.IO.Path.GetFullPath(@"..\..\Practice\Формы права.txt"));
            files.Add(System.IO.Path.GetFullPath(@"..\..\Practice\Правовые акты.txt"));
            for (int i = 0; i < files.Count; i++)
            {

               
                
                titles.Add(System.IO.Path.GetFileNameWithoutExtension(files[i]));
               

            }
            Task.Text = titles[PracticePage.numb];

            StreamReader reader = new StreamReader(File.Open
                  (files[PracticePage.numb], FileMode.Open));
            string[] mass = reader.ReadToEnd().Split('a');
            
            textBlock.Text = mass[0].Trim('\r');
            textBlock.FontSize = 20;
            textBlock.TextWrapping= TextWrapping.Wrap;
            textBlock.Margin = new Thickness(20, 0, 0, 0);
            Items.Children.Add(textBlock);

            rightAnswer = mass[1].Trim('\r');
            textBox.Margin = new Thickness(20, 0, 0, 0);
            Items.Children.Add(textBox);
            reader.Close();
        }





        private void SaveAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == rightAnswer)
            {
                System.Windows.Forms.MessageBox.Show("Ты молодец", "Отлично",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                System.Windows.Forms.MessageBox.Show("Подумай еще", "Неправильно",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        

       
        
    }
}
