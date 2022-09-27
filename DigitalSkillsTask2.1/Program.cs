/*Напишите консольное приложение на C#, которое на вход принимает большой текстовый файл 
 * (например «Война и мир», можно взять отсюда http://az.lib.ru/). На выходе создает текстовый файл 
 * с перечислением всех уникальных слов, встречающихся в тексте, и количеством их употреблений, 
 * отсортированный в порядке убывания количества употреблений, например:
d'artifice		50
говорит		48
значительно		30    */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalSkillsTask2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            char[] separator = new char[] { ',', ' ', '.', ':', ';' ,'?','.','-','!','"'};
            Dictionary<string, int> testTask = new Dictionary<string, int>();
            string userAnswer = "";
            while(userAnswer=="")//цикл, позволяющий считать слова для нескольких файлов
            {
                string path = "";
                Console.WriteLine("Введите путь к файлу");

                path = Console.ReadLine();
                while (true)//проверка на правильность указания пути. Если путь введен неверно,
                            //требуется повторить ввод
                {
                    if (File.Exists(path))
                    {

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Файл не найден,введите еще раз");
                        path = Console.ReadLine();
                    }

                }
                //вызов метода заполнения словаря
                Dictionary<string, int> writeToFileDict = FillDict(testTask, path, separator);
                if(writeToFileDict.Count()==0)
                {
                    Console.WriteLine("Файл пуст!");
                    continue;
                }
                string fileName = Path.GetFileNameWithoutExtension(path);

                string wordCountFileName = fileName + "_word_count_result.txt";//задание имени файла с
                                                                               //результатами подсчета
                string proectPath = Application.StartupPath;
                string pathForResultsFiles = proectPath + "/файлы_результатов_подсчета/";

                CreateResultFile(pathForResultsFiles, wordCountFileName, writeToFileDict, path);
                Console.WriteLine("Для нового подсчета нажмите Enter");
                userAnswer=Console.ReadLine();
            }
            Console.WriteLine("Работа окончена");
            
            Console.ReadKey();
        }
        //метод, возвращающий словь,заполненный словами из файла(ключ) и их количеством(значение)
        public static Dictionary<string, int> FillDict(Dictionary<string, int> testTask,string path, char[] separators)
        {
            List<string> lineText = File.ReadAllLines(path).ToList();
           
            string fileName = Path.GetFileNameWithoutExtension(path);
            foreach (string line in lineText)
            {
                //разделение полученного из файла текста на слова с помощью переданных в метод разделителей
                List<string> words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
                

                foreach (string word in words)
                {
                    string w = word.ToLower();
                    w = Regex.Replace(w, @"[^\w]*", String.Empty);//удаление небуквенных символов из строки

                    if (!testTask.ContainsKey(w))//проверка на наличие ключа в словаре
                    {
                        testTask.Add(w, 1);
                    }
                    else
                        testTask[w]++;
                }
                testTask.Remove("");//удаление ключей-пустых строк

            }
            //сортировка значений словаря по убыванию
            Dictionary<string, int> writeToFileDict = testTask.OrderByDescending(v => v.Value).ToDictionary(k => k.Key, v => v.Value);
            return writeToFileDict;
        }
        //метод, создающий папку(для всех файлов с результатами) рядом с exe файлом проекта
        //(если не существует) и файл
        //с результатами подсчета слов в тексте(если не существует)
        //Если файл существует,выводится соответсвующее сообщение
        public static void CreateResultFile(string pathForResultsFiles,string wordCountFileName,
            Dictionary<string,int> writeToFileDict,string path)
        {
            if (!Directory.Exists(pathForResultsFiles))
            {
                Directory.CreateDirectory(pathForResultsFiles);
            }
            if (!File.Exists(pathForResultsFiles + wordCountFileName))
            {
                File.Create(pathForResultsFiles + wordCountFileName).Close();

                //запись полученых значений в текстовый файл
                File.WriteAllLines(
                pathForResultsFiles + wordCountFileName,
                writeToFileDict.Select(kvp => string.Format($"{kvp.Key,20} \t {kvp.Value,10}")));
                if (File.Exists(pathForResultsFiles + wordCountFileName)) Console.WriteLine
                        ($"Файл с результатами подсчета слов для файла {Path.GetFileName(path)} успешно создан" +
                        $".Путь {pathForResultsFiles + wordCountFileName}");
                else Console.WriteLine("Ошибка создания");
            }
            else Console.WriteLine($"Файл с результатами подсчета слов для файла {Path.GetFileName(path)} " +
                $"уже существует.Путь {pathForResultsFiles + wordCountFileName}");
        }

    }
}
