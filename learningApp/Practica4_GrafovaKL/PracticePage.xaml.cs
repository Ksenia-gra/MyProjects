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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для PracticePage.xaml
    /// </summary>
    public partial class PracticePage : Page
    {
        List<Button> buttonList=new List<Button>();
        public static int numb = 0;
        public PracticePage()
        {
            InitializeComponent();
            buttonList.Add(CardPractice1);
            buttonList.Add(CardPractice2);
            buttonList.Add(CardPractice3);
            buttonList.Add(CardPractice4);
        }

        private void CardPractice_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0;i<buttonList.Count;i++)
            {
                if ((sender as Button).Name == buttonList[i].Name) numb = i;
            }
            PracticeExersicesPage practiceExersicesPage = new PracticeExersicesPage();
            ManagerNavigation.MainFrame.Navigate(new PracticeExersicesPage());
        }
    }
}
