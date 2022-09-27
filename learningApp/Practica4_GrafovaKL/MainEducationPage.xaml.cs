using Practica4_GrafovaKL.Data;
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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для MainEducationPage.xaml
    /// </summary>
    public partial class MainEducationPage : Page
    {
        List<Button> buttonsTeory = new List<Button>();
        ApplicationContext application = new ApplicationContext();
        public MainEducationPage()
        {
            InitializeComponent();
            TestProgress.Value = TestPage.result;
            TextTestProgress.Text = TestPage.result.ToString()+"/"+ TestProgress.Maximum.ToString();
            application.DbTeory.Load();
            buttonsTeory.Add(Teory1);
            buttonsTeory.Add(Teory2);
            buttonsTeory.Add(Teory3);
            buttonsTeory.Add(Teory4);
            buttonsTeory.Add(Teory5);
           
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            
            CardStat.Margin= new Thickness( 0,40+e.VerticalOffset,0, 0);
            

        }

        private void BeginTest_Click(object sender, RoutedEventArgs e)
        {                      
            ManagerNavigation.MainFrame.Navigate(new TestPage(MainWindow.test));
            MainWindow.Instance.TestPage_Click(sender, e);
        }

        private void Teory_Click(object sender, RoutedEventArgs e)
        {
            List<Teory> list = new List<Teory>();
            foreach (Teory teoryin in application.DbTeory)
            {

                list.Add(teoryin);
            }
            
            for (int i = 0; i < buttonsTeory.Count; i++)
            {
                if ((sender as Button).Name == buttonsTeory[i].Name)
                {
                    TeoryTheme teoryTheme = new TeoryTheme(list[i].Path, list[i].Title);
                    ManagerNavigation.MainFrame.Navigate(new TeoryTheme(list[i].Path, list[i].Title));
                }

            }
        }
        
    }
}
