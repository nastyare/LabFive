using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace LabFive
{
    class File
    {
        static void Main(string[] args)
        {
            Console.Write("Вставьте путь к файлу: ");
            string Path = Console.ReadLine();
            FileInfo fileInfo = new FileInfo(Path);
            if (!fileInfo.Exists)
            {
                Console.WriteLine("Такого файла нет.");
            }
            int UserChoice = 0;
            while (UserChoice != 3)
            {
                Console.WriteLine("Что сделать с файлом?\n1.Исправить номера телефонов.\n2.Заменить ошибочные слова.\n3.Exit.");
                while (UserChoice < 1 || UserChoice > 3)
                {
                    if (int.TryParse(Convert.ToString(Console.ReadLine()), out UserChoice) == false)
                    {
                        Console.WriteLine("Такой опции нет");
                    }
                }
                Console.Clear();
               
                switch (UserChoice)
                {
                    case 1:
                        Console.Clear();
                        EditPhoneNumbers.EditorOfPhoneNumbers(Path);
                        UserChoice = 0;
                        break;
                    case 2:
                        Console.Clear();
                        ChangingWords.SearchingWrongWords(Path);
                        UserChoice = 0;
                        break;
                }
                
            }
            Console.ReadKey();
        }

    }
}