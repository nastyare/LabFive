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
            var Words = new List<string>()
            {
               "helo", "helllo", "goodby", "goodbey"
            };
            var UsingWords = new List<string>(Words);
            
            for (int i = 0; i < UsingWords.Count; ++i)
            {
                if (UsingWords[i] == "helo" || UsingWords[i] == "helllo")
                {
                    string Word = UsingWords[i];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
                    {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word))
                    {
                        string RightWord = "Hello";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
                        {
                            File.Write(Result);
                        }
                    }
                }
                else if (UsingWords[i] == "goodby" || UsingWords[i] == "goodbey" || UsingWords[i] == "goodbe")
                {
                    string Word = UsingWords[i];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
                    {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word))
                    {
                        string RightWord = "Goodbye";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
                        {
                            File.Write(Result);
                        }
                    }
                }
            } 
            Console.Clear();
            Console.Write("Ошибочные слова успешно изменены");
            Console.ReadKey();
        }         
    }
}
