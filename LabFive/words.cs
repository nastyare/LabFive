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
               "пирвет", "првиет", "привте", "здраствуйте", "сдравствуйте", "сдраствуйте"
            };
            var UsingWords = new List<string>(Words);
            
            for (int IndexOfWord = 0; IndexOfWord < UsingWords.Count; ++IndexOfWord)
            {
                if (UsingWords[IndexOfWord] == "пирвет" || UsingWords[IndexOfWord] == "првиет" || UsingWords[IndexOfWord] == "привте")
                {
                    string Word = UsingWords[IndexOfWord];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
                    {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word))
                    {
                        string RightWord = "Привет";
                        string Result = Text.Replace(Word, RightWord);
                        using (System.IO.StreamWriter File = new System.IO.StreamWriter(Path))
                        {
                            File.Write(Result);
                        }
                    }
                }
                else if (UsingWords[IndexOfWord] == "здраствуйте" || UsingWords[IndexOfWord] == "сдравствуйте" || UsingWords[IndexOfWord] == "сдраствуйте")
                {
                    string Word = UsingWords[IndexOfWord];
                    string Text = string.Empty;
                    using (System.IO.StreamReader Reader = System.IO.File.OpenText(Path))
                    {
                        Text = Reader.ReadToEnd();
                    }
                    if (Text.Contains(Word))
                    {
                        string RightWord = "Здравствуйте";
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
