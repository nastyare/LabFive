using System;
using System.IO;
using System.Text.RegularExpressions; 

namespace LabFive
{
    internal class EditPhoneNumbers
    {
        public static void EditorOfPhoneNumbers(string Path)
        {
            string FirstNumber = "(012) 345-67-89";
            string str = string.Empty;
            using (System.IO.StreamReader reader = System.IO.File.OpenText(Path))
            {
                str = reader.ReadToEnd();
            }

                if (str.Contains(FirstNumber))
                {
                    //string FirstNumber = "(012) 345-67-89";
                    string Pattern = @"\D(\S{4})\D\S*";
                    string Result = "+380 12 345 67 89";
                    Regex regex = new Regex(Pattern);
                    string ResultOfConvert = regex.Replace(FirstNumber, Result);
                string Fin = str.Replace(FirstNumber, ResultOfConvert);

                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(Path))
                    {
                        file.Write(Fin);
                    }

                }
            
            Console.Clear();
            Console.WriteLine("Номера телефонов успешно заменены");
            Console.ReadKey();

        }
    }
}
