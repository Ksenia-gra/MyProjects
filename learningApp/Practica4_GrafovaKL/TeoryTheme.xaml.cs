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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practica4_GrafovaKL
{
    /// <summary>
    /// Логика взаимодействия для TeoryTheme.xaml
    /// </summary>
    public partial class TeoryTheme : Page
    {
        
        public TeoryTheme(string path,string title)      //Передай сюда полный путь файла ртф
        {
            InitializeComponent();
            ReadDocument(path);

            Title.Text=title;
        }

        private void ReadDocument(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException();
            }

            TextRange doc = new TextRange(Text.Document.ContentStart, Text.Document.ContentEnd);
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                doc.Load(fs, DataFormats.Rtf);
            }
        }
    }
}
