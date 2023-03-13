using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LabFive
{
    class File
    {
        static void FileOne()
        {
            Console.Write("Вставьте путь к файлу: ");
            string Path = Console.ReadLine();   
            FileInfo fileInfo = new FileInfo(Path);
            if (!fileInfo.Exists)
            {
                Console.WriteLine("Такого файла нет.");
            } 
        }
        static void Main(string[] args)
        {
            FileOne();
            int UserChoice = 0;
            while (UserChoice != 3)
            {
                Console.WriteLine("Что сделать с файлом?\n1.Исправить ошибочные слова.\n2.Заменить номера телефонов.\n3.Exit.");
                while (UserChoice < 1 || UserChoice > 3)
                {
                    if (int.TryParse(Convert.ToString(Console.ReadLine()), out UserChoice) == false)
                    {
                        Console.WriteLine("Такой опции нет");
                    }
                }
                Console.Clear();
                //FileStream File = new FileStream(FilePath, FileMode.Open);
                switch (UserChoice)
                {
                    case 1:
                        Console.Write("Okey");
                        break;
                    //вызов метода, который заменяет ошибочные слова
                    case 2:
                        Console.Write("No prob");
                        break;
                        //вызов регулярного выражения, которое заменит номера телефонов
                }
                Console.ReadKey();
            }
        }

    }
}