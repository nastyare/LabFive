using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Collections;

namespace LabFive
{
    internal class ChangingWords
    {
        public static void SearchingWrongWords(string Path)
        {
           /* Dictionary<string, string> MyDictionary = new Dictionary<string, string>()
            {
                [0] = "Привет",
                [1] = "Здравствуйте",
                [2] = "До свидания"
            };*/
            

            string WrongWord = "пирвет";

            string Text = string.Empty;
            using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
            {
                Text = Reader.ReadToEnd();
            }

            if (Text.Contains(WrongWord))
            {
                string RightWord = "привет";
                string Result = Text.Replace(WrongWord, RightWord);
                using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
                {
                    File.Write(Result);
                }
            }
            Console.Clear();
            Console.Write("Ошибочное слово успешно изменено");
        }         
    }
}
