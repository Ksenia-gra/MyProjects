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
    /// Логика взаимодействия для TestPage.xaml
    /// </summary>
    public partial class TestPage : Page
    {
        int count = 0;
        
        ApplicationContext application = new ApplicationContext();
        List<System.Windows.Controls.RadioButton> radioButtons = new List<System.Windows.Controls.RadioButton>();
        List<System.Windows.Controls.CheckBox> checkBoxes = new List<System.Windows.Controls.CheckBox>();
        List<System.Windows.Controls.TextBox> textBoxes = new List<System.Windows.Controls.TextBox>();
        List<string> answers= new List<string>();
        List<string> rightAnswers = new List<string>();
        public static int result = 0;
        public TestPage(List<Question>test)
        {

            InitializeComponent();
            result = 0;
            answers.Clear();
            application.DbQuestions.Load();
            NextQuest.IsEnabled = true;
            FinishTest.IsEnabled = false;
            Quest.Text = MainWindow.test[count].QuestionText;
            if (MainWindow.test[count].QuestionType == 1)
            {

                for (int i = 0; i < MainWindow.test[count].Answers.Count; i++)
                {
                     TextBlock textBlock = new TextBlock();
                    textBlock.Text += MainWindow.test[count].Answers[i].AnswerText;
                    textBlock.FontSize = 14;
                    textBlock.FontWeight = FontWeights.Bold;
                    RadioButton radioButton = new RadioButton();

                    Items.Children.Add(radioButton);
                    Items.Children.Add(textBlock);
                    radioButtons.Add(radioButton);

                }
            }
            if (MainWindow.test[count].QuestionType == 2)
            {

                for (int i = 0; i < MainWindow.test[count].Answers.Count; i++)
                {

                    TextBlock textBlock = new TextBlock();
                    textBlock.Text += MainWindow.test[count].Answers[i].AnswerText + "\n";
                    textBlock.FontSize = 14;
                    textBlock.FontWeight = FontWeights.Bold;

                    CheckBox checkBox = new CheckBox();
                    checkBoxes.Add(checkBox);
                    Items.Children.Add(checkBox);
                    Items.Children.Add(textBlock);
                }
            }
            if (MainWindow.test[count].QuestionType == 3)
            {

                TextBox textBox = new TextBox();
                Items.Children.Add(textBox);
                textBoxes.Add(textBox);
            }
            count++;
            ProgressB.Value++;
            

        }

        private void NextQuest_Click(object sender, RoutedEventArgs e)
        {
            bool s = false;

            for (int i = 0; i < radioButtons.Count(); i++)
            {
                if (radioButtons[i].IsChecked == true)
                {
                    answers.Add((i + 1).ToString());
                    s = true;
                    break;
                }
            }
            if (radioButtons.Count() != 0)
                if (s == false) answers.Add("");
            radioButtons.Clear();


            string st = "";
            for (int i = 0; i < checkBoxes.Count(); i++)
            {
                if (checkBoxes[i].IsChecked == true)
                {
                    st += (i + 1).ToString();
                }
            }
            if (checkBoxes.Count() != 0)
                answers.Add(st);
            checkBoxes.Clear();


            for (int i = 0; i < textBoxes.Count(); i++)
            {
                answers.Add(textBoxes[i].Text);
            }
            textBoxes.Clear();

            if (count == MainWindow.test.Count)
            {
                
                NextQuest.IsEnabled = false;
                FinishTest.IsEnabled = true;
                ProgressB.Value++;
                return;
            }
            Items.Children.Clear();
            
            Quest.Text = MainWindow.test[count].QuestionText;
            if (MainWindow.test[count].QuestionType == 1)
            {

                for (int i = 0; i < MainWindow.test[count].Answers.Count; i++)
                {
                    TextBlock textBlock=new TextBlock();
                    textBlock.Text += MainWindow.test[count].Answers[i].AnswerText;
                    textBlock.FontSize = 14;
                    textBlock.FontWeight= FontWeights.Bold;
                    RadioButton radioButton = new RadioButton();

                    Items.Children.Add(radioButton);
                    Items.Children.Add(textBlock);
                    radioButtons.Add(radioButton);
                }
            }
            if (MainWindow.test[count].QuestionType == 2)
            {

                for (int i = 0; i < MainWindow.test[count].Answers.Count; i++)
                {

                    TextBlock textBlock = new TextBlock();
                    textBlock.Text += MainWindow.test[count].Answers[i].AnswerText + "\n";
                    textBlock.FontSize = 14;
                    textBlock.FontWeight = FontWeights.Bold;

                    CheckBox checkBox = new CheckBox();
                    Items.Children.Add(checkBox);
                    Items.Children.Add(textBlock);
                    checkBoxes.Add(checkBox);
                }
            }
            if (MainWindow.test[count].QuestionType == 3)
            {

                TextBox textBox = new TextBox();
                Items.Children.Add(textBox);
                textBoxes.Add(textBox);
            }

            count++;
            ProgressB.Value++;

            return;
                
        }

        private void FinishTest_Click(object sender, RoutedEventArgs e)
        {
            for(int i=0; i < MainWindow.test.Count; i++)
            {
                for(int j=0;j < MainWindow.test[i].Answers.Count; j++)
                {
                    if (answers[i] == MainWindow.test[i].Answers[j].AnswerText) result++;
                }
                    
            }
            if (result >= (answers.Count() - 3))
            {
                System.Windows.Forms.MessageBox.Show(result.ToString(), "Отлично",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else if (result >= (answers.Count() - 6))
            {
                System.Windows.Forms.MessageBox.Show(result.ToString(), "Хорошо",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else if (result >= (answers.Count() / 2))
            {
                System.Windows.Forms.MessageBox.Show(result.ToString(), "Удовлетворительно",
                          System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            else if (result <= (answers.Count() / 2))
            {
                System.Windows.Forms.MessageBox.Show(result.ToString(), "Не получилось",
                 System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            }
        }
    }
}
