using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using static System.Net.WebRequestMethods;
using File = System.IO.File;
using Path = System.IO.Path;

namespace Lab1Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, DateTime> openedFiles = new Dictionary<string, DateTime>();
        DriveInfo[] drives = DriveInfo.GetDrives();
        string openedDir = "";
        
        public MainWindow()
        {
            InitializeComponent();
           
            foreach (DriveInfo drive in drives)
            {
                openedDir = Path.GetDirectoryName(drive.Name);
                comboBox1.Items.Add(drive);
                comboBox1.FontSize = 18;
                comboBox1.SelectedIndex = 0;   
            }
            
            
           
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e )
        {
            listBox1.Items.Clear();           
            listBox2.Items.Clear();

            backButton.IsEnabled = false;
            driveFreeSpace.Text = string.Empty;
            driveVolume.Text = string.Empty;

            DriveInfo drive = new DriveInfo(comboBox1.SelectedItem.ToString());
            openedDir = Path.GetDirectoryName(drive.Name);
            DirectoryInfo dirInfo = new DirectoryInfo(drive.Name);
            fullPathName.Text = dirInfo.FullName;
            createTime.Text = dirInfo.CreationTime.ToString();
            rootDirectory.Text = dirInfo.Root.ToString();

            if (drive.IsReady)
            {
                driveFreeSpace.Text = Math.Round(drive.TotalFreeSpace / (Math.Pow(2, 30)), 2) + " Гб";
                driveVolume.Text = Math.Round(drive.TotalSize / (Math.Pow(2, 30)), 2) + " Гб";
                listBox2.IsEnabled = true;
                listBox1.IsEnabled = true;

                foreach (string file in GetFilesInDirecrory(drive.Name))
                {
                    listBox2.Items.Add(file);
                }
                foreach (string directory in GetDirecroriesInRootDir(drive.Name))
                {
                    listBox1.Items.Add(directory);
                }
            }
            else
            {
                listBox1.Items.Add("Диск недоступен");
                listBox1.IsEnabled = false;
            }   
        }
        private List<string> GetFilesInDirecrory(string path)
        {            
            return Directory.GetFiles(path).ToList();
        }

        private List<string> GetDirecroriesInRootDir(string path)
        {
            return Directory.GetDirectories(path).ToList();
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            listBox2.IsEnabled = true;
            
            if (listBox1.SelectedItem != null)
            {
                string directory = listBox1.SelectedItem.ToString();
                DirectoryInfo dirInfo = new DirectoryInfo(listBox1.SelectedItem.ToString());
                fullPathName.Text = dirInfo.FullName;
                createTime.Text = dirInfo.CreationTime.ToString();
                rootDirectory.Text = dirInfo.Root.ToString();
                try
                {
                    listBox2.Items.Clear();
                    openedDir = Path.GetDirectoryName(directory);
                    if (GetFilesInDirecrory(directory).Count == 0)
                    {
                        listBox2.Items.Add("Папка пуста");
                        listBox2.IsEnabled = false;
                    }
                    else
                    {
                        foreach (string file in GetFilesInDirecrory(directory))
                        {
                            listBox2.Items.Add(file);
                        }
                    }
                }
                catch
                {
                    listBox2.Items.Add("Доступ запрещен");
                    listBox2.IsEnabled = false;
                }
            }
        }
    
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime windCloseTime=DateTime.Now;
            string path= Directory.GetCurrentDirectory()+"/Текстовый файл/";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(path + "filesNames.txt"))
            {
                File.Create(path + "filesNames.txt").Close();
            }

            Dictionary<string, DateTime> currentOpenedFiles = 
                                                openedFiles.Where(f => f.Value >= windCloseTime.
                                                AddSeconds(-10)).ToDictionary(f => f.Key, f => f.Value);
            File.WriteAllLines(
                    path + "filesNames.txt",
                    currentOpenedFiles.Select(kvp => string.Format($"{kvp.Key,20} \t {kvp.Value,10}")));

        }

        private void listBox2_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {                
                Process.Start(listBox2.SelectedItem.ToString());

                if (!openedFiles.ContainsKey(listBox2.SelectedItem.ToString()))
                {
                    openedFiles.Add(listBox2.SelectedItem.ToString(), DateTime.Now);
                }
                else
                {
                    openedFiles[listBox2.SelectedItem.ToString()] = DateTime.Now;
                }
            }
                
        }

        private void listBox1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            backButton.IsEnabled = true;
            
            string directory = listBox1.SelectedItem.ToString();
            DirectoryInfo dirInfo = new DirectoryInfo(directory);
            fullPathName.Text = dirInfo.FullName;
            createTime.Text = dirInfo.CreationTime.ToString();
            rootDirectory.Text = dirInfo.Root.ToString();

            try
            {
                listBox2.Items.Clear();
                openedDir = directory;

                if (GetDirecroriesInRootDir(directory).Count != 0)
                {
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                       
                    foreach (string dir in GetDirecroriesInRootDir(directory))
                    {
                        listBox1.Items.Add(dir);
                    }
                }
                if (GetFilesInDirecrory(directory).Count == 0)
                {
                    listBox2.Items.Add("Папка пуста");
                    listBox2.IsEnabled = false;
                }
                else
                {
                    foreach (string file in GetFilesInDirecrory(directory))
                    {
                        listBox2.Items.Add(file);
                    }
                }

            }
            catch
            {
                listBox2.Items.Add("Доступ запрещен");
                listBox2.IsEnabled = false;
            }
            
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            DirectoryInfo dirInfo = new DirectoryInfo(Directory.GetParent(openedDir).ToString());
            fullPathName.Text = dirInfo.FullName;
            createTime.Text = dirInfo.CreationTime.ToString();
            rootDirectory.Text = dirInfo.Root.ToString();
            listBox2.IsEnabled = true;
            foreach (DriveInfo drive in drives)
            {
                if (drive.Name == Directory.GetParent(openedDir).ToString())
                {
                    backButton.IsEnabled = false;
                    break;
                }
            }

            List<string> dirs = GetDirecroriesInRootDir(Directory.GetParent(openedDir).ToString());

            foreach (var dir in dirs)
            {
                listBox1.Items.Add(dir);
            }

            List<string> files = GetFilesInDirecrory(Directory.GetParent(openedDir).FullName);

            if (files.Count == 0)
            {
                listBox2.Items.Add("Папка пуста");
                listBox2.IsEnabled = false;
            }
            else
            {
                foreach (string file in files)
                {
                    listBox2.Items.Add(file);
                }
            }
                        
            openedDir = Directory.GetParent(openedDir).ToString();
        }
    }
}
