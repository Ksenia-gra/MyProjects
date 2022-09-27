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

namespace Pract3_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> input = new List<string>();
        List<List<System.Windows.Controls.Button>> buttonList = new List<List<System.Windows.Controls.Button>>();
        List<System.Windows.Controls.TextBox> textBoxes= new List<System.Windows.Controls.TextBox>();
        List<TextBlock> checkBlocks = new List<TextBlock>();
        public MainWindow()
        {
            InitializeComponent();

            ColumnDefinition column1= new ColumnDefinition();
            Grid.ColumnDefinitions.Add(column1);
            column1.Width = GridLength.Auto;
            RowDefinition row1 = new RowDefinition();
            row1.Height = GridLength.Auto;
            TextBlock textBlock1 = new TextBlock();
            textBlock1.Width = 35;
            textBlock1.Height = 35;
            textBlock1.Background = new SolidColorBrush(Colors.White);
            Grid.Children.Add(textBlock1);
            Grid.SetColumn(textBlock1,0);
            Grid.SetRow(textBlock1, 0);
            Grid.RowDefinitions.Add(row1);
            for (int i = 1; i < 17; i++)
            {
               
                TextBlock textBlock = new TextBlock();
                textBlock.Width = 35;
                textBlock.Height = 35;
                textBlock.Background = new SolidColorBrush(Colors.White);
                Grid.Children.Add(textBlock);
                textBlock.Text = (i).ToString();
                textBlock.TextAlignment=TextAlignment.Center;
                textBlock.Foreground = new SolidColorBrush(Colors.DeepSkyBlue);
                textBlock.FontWeight = FontWeights.Bold;
                Grid.SetColumn(textBlock, i);
                Grid.SetRow(textBlock, 0);

            }
            for (int i = 1; i < 17; i++)
            {

                TextBlock textBlock = new TextBlock();
                textBlock.Width = 35;
                textBlock.Height = 35;
                textBlock.Background = new SolidColorBrush(Colors.White);
                Grid.Children.Add(textBlock);
                textBlock.Text = (i).ToString();
                textBlock.TextAlignment = TextAlignment.Center;
                textBlock.Foreground = new SolidColorBrush(Colors.DeepSkyBlue);
                textBlock.FontWeight = FontWeights.Bold;
                Grid.SetColumn(textBlock, 0);
                Grid.SetRow(textBlock, i);

            }
           
            for (int i = 0; i < 16; i++)
            {
                List<System.Windows.Controls.Button> buttons = new List<System.Windows.Controls.Button>();
                RowDefinition rowContent = new RowDefinition();
                rowContent.Height = GridLength.Auto;
                Grid.RowDefinitions.Add(rowContent);
                for (int j = 0; j < 16; j++)
                {
                    ColumnDefinition columnContent = new ColumnDefinition();
                    columnContent.Width = GridLength.Auto;
                    Grid.ColumnDefinitions.Add(columnContent);
                    System.Windows.Controls.Button myButton = new System.Windows.Controls.Button();
                    myButton.Width = 35;
                    myButton.Height = 35;
                    myButton.Background = new SolidColorBrush(Colors.White);
                    myButton.BorderBrush = new SolidColorBrush(Colors.Lavender);
                    myButton.Click +=Draw_Click;

                    Grid.Children.Add(myButton);
                    Grid.SetColumn(myButton,j+1);
                    Grid.SetRow(myButton, i+1);
                    buttons.Add(myButton);

                }
                buttonList.Add(buttons);
            }
            System.Windows.Controls.Button table = new System.Windows.Controls.Button();
           
  
            table.Background = new SolidColorBrush(Colors.DeepSkyBlue);
            table.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue);
            table.Foreground = new SolidColorBrush(Colors.White);
            table.BorderThickness = new Thickness(5);
            table.Content = "Таблица кодов";
            table.FontWeight = FontWeights.Bold;
            Grid.Children.Add(table);
            Grid.SetRow(table, 0);
            Grid.SetColumn(table, 17);
            table.Click += OpenTable_Click;
            table.Width = 150;
            table.Height = 35;
            
            ColumnDefinition column2 = new ColumnDefinition();
            Grid.ColumnDefinitions.Add(column2);
            column2.Width = GridLength.Auto;
            

            RowDefinition row2 = new RowDefinition();
            Grid.RowDefinitions.Add(row2);
            row2.Height = GridLength.Auto;
            

            for (int i = 0; i < 16; i++)
            {
                    System.Windows.Controls.TextBox textBox = new System.Windows.Controls.TextBox();
                    textBox.Background= new SolidColorBrush(Colors.White);
                    textBox.BorderBrush = new SolidColorBrush(Colors.Lavender);
                    textBox.FontWeight = FontWeights.Bold;
                    textBox.BorderBrush=new SolidColorBrush(Colors.Pink);
                    textBox.MaxWidth = 150;
                    textBox.MaxHeight = 35;
                    textBox.FontSize = 16;
                    textBox.TextWrapping= TextWrapping.Wrap;
                    textBox.PreviewTextInput += RightPreviewTextInput;
                    Grid.Children.Add(textBox);
                    Grid.SetColumn(textBox, 17);
                    Grid.SetRow(textBox, i + 1);
                    textBoxes.Add(textBox);
                
            }


            RowDefinition row3 = new RowDefinition();
            Grid.RowDefinitions.Add(row3);
            row3.Height = GridLength.Auto;
            
            System.Windows.Controls.Button exit = new System.Windows.Controls.Button();
            exit.Click += Exit_Click;
            exit.Background = new SolidColorBrush(Colors.HotPink);
            exit.BorderBrush = new SolidColorBrush(Colors.HotPink);
            exit.Foreground = new SolidColorBrush(Colors.White);
            exit.BorderThickness = new Thickness(5);
            exit.Content = "Выход";
            exit.FontWeight = FontWeights.Bold;
            Grid.Children.Add(exit);

            exit.Width = 150;
            exit.Height = 47;
            Grid.SetColumn(exit, 17);
            Grid.SetRow(exit, 18);
            System.Windows.Controls.Button checkButton = new System.Windows.Controls.Button();

            checkButton.Background = new SolidColorBrush(Colors.DeepSkyBlue);
            checkButton.BorderBrush = new SolidColorBrush(Colors.DeepSkyBlue);
            checkButton.Foreground = new SolidColorBrush(Colors.White);
            checkButton.BorderThickness = new Thickness(5);
            checkButton.Content = "Проверить!";
            checkButton.FontWeight = FontWeights.Bold;
            Grid.Children.Add(checkButton);

            checkButton.Width = 150;
            checkButton.Height = 47;
            Grid.SetColumn(checkButton, 17);
            Grid.SetRow(checkButton, 17);

            checkButton.Click += CheckButton_Click;

            



        }
        private void RightPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789ABCDEF".IndexOf(e.Text) < 0;
        }
        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {
            input.Clear();
            checkBlocks.Clear();
            for (int i = 0; i < 16; i++)
            {
                input.Add(textBoxes[i].Text);

            }
            for (int i = 0; i < 16; i++)
            {


                TextBlock textBlock = new TextBlock();
                

                textBlock.Width = 15;
                textBlock.Height = 15;
                textBlock.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
                textBlock.Margin = new Thickness(0, 0, 5, 0);
                Grid.Children.Add(textBlock);
                Grid.SetColumn(textBlock, 17);
                Grid.SetRow(textBlock, i + 1);
                checkBlocks.Add(textBlock);

            }
            
            List<string> parseInput = Parse(input);
            if (parseInput==null)
            {
                System.Windows.Forms.MessageBox.Show("Есть пустые строки", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<string> rightAnswers = GetRightResult(buttonList);
            for (int i = 0; i < rightAnswers.Count(); i++)
            {
               
                if (CompareAnswers(parseInput[i], rightAnswers[i]))
                {
                    checkBlocks[i].Background = new SolidColorBrush(Colors.LawnGreen);

                   
                }
                   
                else
                {
                    checkBlocks[i].Background = new SolidColorBrush(Colors.Red);
                    
                }
                


            }
            parseInput.Clear();
            rightAnswers.Clear();
  
           
        }

    

        private void Draw_Click(object sender, RoutedEventArgs e)
        {
            if (((SolidColorBrush)(sender as System.Windows.Controls.Button).Background).Color==Colors.Lavender)
                (sender as System.Windows.Controls.Button).Background = new SolidColorBrush(Colors.White);
            else 
                (sender as System.Windows.Controls.Button).Background = new SolidColorBrush(Colors.Lavender);


        }
        private void OpenTable_Click(object sender, RoutedEventArgs e)
        {
           
            Table codeTable=new Table();
            codeTable.Show();

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {

            DialogResult res = new DialogResult();
            res = System.Windows.Forms.MessageBox.Show("Действительно хотите выйти?", "Выход из программы",
            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            { Close(); }
            else { return; }

        }
        List<string> GetRightResult(List<List<System.Windows.Controls.Button>> buttonList)
        {
            List<string> result =new List<string>();
            foreach( List < System.Windows.Controls.Button > buttons in buttonList)
            {
                string s = "";
                foreach (System.Windows.Controls.Button button in buttons)
                {
                    
                    if (((SolidColorBrush)(button).Background).Color == Colors.Lavender)
                        s+= "1";
                    else
                        s += "0";
                    
                }
                
                result.Add(s);
            }
            return result;
        }
        List<string> Parse(List<string> texts)
        {
            List<string> input = new List<string>();
            try
            {
                foreach (string text in texts)
                {
                    int parsing = Convert.ToInt32(text, 16);
                    string strParse = Convert.ToString(parsing, 2);
                    if (strParse.Length != 16 && text.Length == 4)
                    {
                        int count = 16 - strParse.Length;
                        for (int i = 0; i < count; i++) strParse = strParse.Insert(0, "0");
                    }
                    input.Add(strParse);
                }
                return input;
            }
               
            catch (Exception ex)
            {
                return null;
            }

   
   
        }
        bool CompareAnswers(string text,string rightResult)
        {
            bool check = false;
           
                if (text == rightResult)
                    check = true;
    
            return check;
        }
    }
}
