using System;
using System.Collections.Generic;
using System.IO;

namespace File_Expation
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public override string ToString()
        {
            return $"{Name} , {SurName}";
        }
    }

    class Translator
    {
        private const string LetterRus = "ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭЯЧСМИТЬБЮйцукенгшщзхъфывапролджэячсмитьбю";
        private const string LetterEng = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm";
        private string TrStr;
        
        public string TranslatorStr(string StrEandR)
        {
            for (int i = 0; i < LetterRus.Length; i++) if (StrEandR[0] == LetterRus[i]) TrStr = StrEandR.ToLower();
            for (int i = 0; i < LetterEng.Length; i++) if (StrEandR[0] == LetterEng[i]) TrStr = StrEandR.ToLower();

          
          
            switch (TrStr)
            {
                case "привет": TrStr = "Hello"; break;
                case "пока": TrStr = "While"; break;
                case "мама": TrStr = "Mom"; break;
                case "папа": TrStr = "Dad"; break;
                case "брат": TrStr = "Brother"; break;
                case "сестра": TrStr = "Sister"; break;
                case "семья": TrStr = "family"; break;
                case "собака": TrStr = "dog"; break;
                case "кошка": TrStr = "cat"; break;
                case "дом": TrStr = "house"; break;
                
                case "автобус": TrStr = "bus"; break;
                case "авто": TrStr = "auto"; break;
                case "мотоцикл": TrStr = "bike"; break;
                case "птица": TrStr = "bird"; break;
                case "корабль": TrStr = "ship"; break;
                case "самолет": TrStr = "Air"; break;
                case "мышка": TrStr = "mouse"; break;
                case "дерево": TrStr = "tree"; break;
                case "небо": TrStr = "sky"; break;
                case "земля": TrStr = "land"; break;

                case "hello": TrStr = "привет"; break;
                case "while": TrStr = "Пока"; break;
                case "mom": TrStr = "Мама"; break;
                case "dad": TrStr = "Папа"; break;
                case "brothe": TrStr = "Брат"; break;
                case "sister": TrStr = "Сестра"; break;
                case "family": TrStr = "Семья"; break;
                case "dog": TrStr = "Собака"; break;
                case "cat": TrStr = "Кошка"; break;
                case "house": TrStr = "Дом"; break;

                case "bus": TrStr = "автобус"; break;
                case "auto": TrStr = "Авто"; break;
                case "bike": TrStr = "Мотоцикл"; break;
                case "bird": TrStr = "Птица"; break;
                case "ship": TrStr = "Корабль"; break;
                case "air": TrStr = "Самолет"; break;
                case "mouse": TrStr = "Мышка"; break;
                case "tree": TrStr = "Дерево"; break;
                case "sky": TrStr = "Небо"; break;
                case "land": TrStr = "Земля"; break;

                default: TrStr = "0";
                    break;
            }
            return TrStr;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Translator OneName = new Translator();
            Console.Write("Enter string, please: ");
            string Str = Console.ReadLine();
            
            if (OneName.TranslatorStr(Str) == "0") Console.WriteLine("No Letter"); else Console.WriteLine(OneName.TranslatorStr(Str));



            //File.WriteAllText("test.txt","Hello my btother");
            /*string text = File.ReadAllText("test.txt");
            Console.WriteLine(text);
            File.AppendAllText("test.txt", "append all");
*/
            /*  Console.Write("Enter symbol: ");
              char Simvol =char.Parse(Console.ReadLine());
              int ONE;
              int TWO;
              while (true)
              {
              Console.Write("Column: ");
              ONE =int.Parse( Console.ReadLine());
                  if (ONE > 0 && ONE < 11) break;
              } 

              while (true)
              {
              Console.Write("Enter Row: ");
              TWO =int.Parse( Console.ReadLine());
                  if (TWO > 0 && TWO < 11) break;
              }*/

            /*for (int i = 0; i < ONE; i++)
             {
                 for (int j = 0; j < TWO; j++)
                 {
                    if (i==0) Console.Write(Simvol);
                    if (i==ONE-1) Console.Write(Simvol);
                    if (i>0 && i < ONE-1 && j==0) Console.Write(Simvol);
                    if (i > 0 && i < ONE - 1 && j != TWO-1 && j != 0  ) Console.Write(" ");
                    if (i > 0 && i < ONE - 1 && j == TWO-1 ) Console.Write(Simvol);

                 }
                 Console.WriteLine();
             }*/


        }
    }
}
