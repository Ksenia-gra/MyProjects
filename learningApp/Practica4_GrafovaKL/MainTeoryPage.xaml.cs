using Practica4_GrafovaKL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;

using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для MainTeoryPage.xaml
    /// </summary>
    public partial class MainTeoryPage : Page
    {
        List<Button> buttonsTeory = new List<Button>();
        ApplicationContext application = new ApplicationContext();
        public MainTeoryPage()
        {
            InitializeComponent();

            application.DbTeory.Load();
            buttonsTeory.Add(CardTeory1);
            buttonsTeory.Add(CardTeory2);
            buttonsTeory.Add(CardTeory3);
            buttonsTeory.Add(CardTeory4);
            buttonsTeory.Add(CardTeory5);


        }

        private void CardTeory_Click(object sender, RoutedEventArgs e)

        {
            List<Teory> list = new List<Teory>();
            foreach(Teory teoryin in application.DbTeory)
            {
               
                list.Add(teoryin);
            }
           
            for (int i = 0; i < buttonsTeory.Count; i++)
            {
                if ((sender as Button).Name == buttonsTeory[i].Name)
                {
                    TeoryTheme teoryTheme = new TeoryTheme(list[i].Path,list[i].Title);
                    ManagerNavigation.MainFrame.Navigate(new TeoryTheme(list[i].Path, list[i].Title));
                }

            }


        }
        
    }
}
