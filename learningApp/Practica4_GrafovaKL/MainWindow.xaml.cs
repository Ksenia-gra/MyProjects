
using Practica4_GrafovaKL.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.IO;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Instance {get; private set;}
        public static User activeUser { get; set; }
        ApplicationContext application=new ApplicationContext();
        public static int c = 0;
        public static List<Question> test=new List<Question>();
        public MainWindow()
        {
            InitializeComponent();
            Instance = this;

            ManagerNavigation.MainFrame = mainFrame;
            mainFrame.Navigate(new MainEducationPage());
            EducationPage.Foreground = new SolidColorBrush(Colors.White);
            SplashScreen splashScreen = new SplashScreen();
            
            splashScreen.ShowDialog();
            application.DbTeory.Load();

            application.SaveChanges();
            List<string>files=new List<string>();
            files.Add(System.IO.Path.GetFullPath(@"../../Teory/Сущность права.rtf"));
            files.Add(System.IO.Path.GetFullPath(@"../../Teory/Правовые нормы.rtf"));
            files.Add(System.IO.Path.GetFullPath(@"../../Teory/Формы права.rtf"));
            files.Add(System.IO.Path.GetFullPath(@"../../Teory/Правовые акты.rtf"));
            files.Add(System.IO.Path.GetFullPath(@"../../Teory/Система права.rtf"));
            for (int i=0;i<files.Count;i++)
            {
                   
                Teory teory = new Teory();
                teory.Path = System.IO.Path.GetFullPath(files[i]);
                teory.Title = System.IO.Path.GetFileNameWithoutExtension(files[i]);
                application.DbTeory.AddOrUpdate(teory);
                application.SaveChanges();

            }
            StreamReader reader = new StreamReader(File.Open
                   (System.IO.Path.GetFullPath(@"..\..\Test\Test.txt"), FileMode.Open));
            string text=reader.ReadToEnd();

            string[] questions = text.Split('Q');
           
            for(int i=0;i<questions.Length;i++)
            {
                List<Answer> answersL = new List<Answer>(); 
                Question question = new Question();
                if (questions[i].Split('a')[0].Contains("/m"))
                {
                    question.QuestionType = 2;
                    question.QuestionText = questions[i].Split('a')[0].Replace("/m", "");
                }
                if (questions[i].Split('a')[0].Contains("/v"))
                {
                    question.QuestionType = 3;
                    question.QuestionText = questions[i].Split('a')[0].Replace("/v", "");

                }
                if (questions[i].Split('a')[0].Contains("/o"))
                {
                    question.QuestionType = 1;
                    question.QuestionText = questions[i].Split('a')[0].Replace("/o", "");

                }



                string[] answers = questions[i].Split('a')[1].Split('\n');
                for(int j=0;j<answers.Length;j++)
                {
                    Answer answer = new Answer();
                    if (answers[j] == string.Empty) break;
                    if(answers[j].Contains('+'))
                    {
                        answer.AnswerText = answers[j].Substring(0, answers[j].Length-2).Trim('\r');
                        answer.isRight = true;

                    }
                    else
                    {
                        answer.AnswerText = answers[j].Substring(0, answers[j].Length).Trim('\r');
                        answer.isRight = false;
                    }

                    answersL.Add(answer);
                }
                question.Answers=answersL;
                c++;
                test.Add(question);
                application.DbQuestions.AddOrUpdate(question);
                application.SaveChanges();
            }


        }

        private void TeoryPage_Click(object sender, RoutedEventArgs e)
        {
            TeoryPage.Foreground = new SolidColorBrush(Colors.White);
            PracticePage.Foreground = new SolidColorBrush(Colors.Black);
            EducationPage.Foreground = new SolidColorBrush(Colors.Black);
            TestPage.Foreground = new SolidColorBrush(Colors.Black);
            ManagerNavigation.MainFrame.Navigate(new MainTeoryPage());
        }

        private void EducationPage_Click(object sender, RoutedEventArgs e)
        {
            TeoryPage.Foreground = new SolidColorBrush(Colors.Black);
            PracticePage.Foreground = new SolidColorBrush(Colors.Black);
            EducationPage.Foreground = new SolidColorBrush(Colors.White);
            TestPage.Foreground = new SolidColorBrush(Colors.Black);
            ManagerNavigation.MainFrame.Navigate(new MainEducationPage());
        }

        private void PracticePage_Click(object sender, RoutedEventArgs e)
        {
            TeoryPage.Foreground = new SolidColorBrush(Colors.Black);
            EducationPage.Foreground = new SolidColorBrush(Colors.Black);
            PracticePage.Foreground = new SolidColorBrush(Colors.White);
            TestPage.Foreground = new SolidColorBrush(Colors.Black);
            ManagerNavigation.MainFrame.Navigate(new PracticePage());
        }

        private void ProfilePage_Click(object sender, RoutedEventArgs e)
        {
           ProfilePage profilePage = new ProfilePage();
            TeoryPage.Foreground = new SolidColorBrush(Colors.Black);
            EducationPage.Foreground = new SolidColorBrush(Colors.Black);
            PracticePage.Foreground = new SolidColorBrush(Colors.Black);
            TestPage.Foreground = new SolidColorBrush(Colors.Black);
            ManagerNavigation.MainFrame.Navigate(new ProfilePage());
        }

        public void TestPage_Click(object sender, RoutedEventArgs e)
        {
            TeoryPage.Foreground = new SolidColorBrush(Colors.Black);
            EducationPage.Foreground = new SolidColorBrush(Colors.Black);
            PracticePage.Foreground = new SolidColorBrush(Colors.Black);
            TestPage.Foreground = new SolidColorBrush(Colors.White);
            ManagerNavigation.MainFrame.Navigate(new TestPage(test));
        }

        
    }
}
