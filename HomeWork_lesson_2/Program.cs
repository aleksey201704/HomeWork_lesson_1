using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ================== Task 1 ==========================
            /*int[] arr = { 0, 5, 1, 23, 59, 1, 45, 99, 1, 33, 7 };

          
            Console.Write("Evan numbers: ");
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            Console.Write("Odd numbers: ");
            for (int i = 0; i < 10; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Unique number: ");
            int NumberUnique = arr[0];
            bool found = false;
            for (int i = 1; i < 10; i++)
            {
                found = false;
                for (int j = 0; j < 10; j++)
                {
                    if (i != j && arr[i] == arr[j]) 
                    {
                        found = true;break; 
                    }
                }
                if (!found) Console.Write(arr[i]+" ");
            }*/

            
            //=========================================================
            // ================== Task 2 ==========================
            /*int[] arr = { 0, 5, 1, 23, 59, 1, 45, 99, 1, 33, 7 };
            Console.Write("Enter the number: ");
            int NumberP = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (NumberP > arr[i]) Console.Write(arr[i]+" ");
            }*/

            //====================================================
            // ================== Task 3 ==========================
            /*int[] arr = { 0, 5, 1, 23, 0, 5, 1, 23, 0, 5, 1 };
            for (int i = 0; i < 11; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
            Console.Write("Enter number one: ");
            int Number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter number two: ");
            int Number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter number three: ");
            int Number3 = int.Parse(Console.ReadLine());
            // 5 1 23
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                if (arr[i] == Number1 && arr[i+1] == Number2 && arr[i+2] == Number3)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of repetitions: " + count);*/

            //====================================================
            // ================== Task 4 ==========================
            /*const int M = 10;
            const int N = 10;
            int[] arr1 = new int[M];
            int[] arr2 = new int[N];
            
            List<int> Shared=new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rnd.Next(10, 30);
                Console.Write(arr1[i]+"  ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rnd.Next(10, 30);
                Console.Write(arr2[i]+"  ");
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Shared.Add(arr1[i]);
                        break;
                    }
                }
            }
            Console.WriteLine();
            
            for (int i = 0; i < Shared.Count-1; i++)
            {
                for (int j =0 ; j < Shared.Count; j++)  if (i !=j && Shared[i] == Shared[j]) Shared.RemoveAt(j);
            }

            for (int i = 0; i < Shared.Count; i++)  Console.Write(Shared[i]+"  ");*/

            //====================================================
            // ================== Task 5 ==========================
            /*int[,] arr = new int[10, 10];
            Random rnd = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(10,50);
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }

            int min = arr[0, 0];
            int max = arr[0, 0];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (min > arr[i, j]) min = arr[i, j];
                    if (max < arr[i, j]) max= arr[i, j];
                 
                }
            }
            Console.WriteLine($"Minimum: {min}");
            Console.WriteLine($"Minimum: {max}");*/

            //====================================================
            // ================== Task 6 ==========================
            /*StringBuilder str = new StringBuilder();
            Console.Write("Enter the line: ");
            str =str.Append(Console.ReadLine());
            int count = 0;
            
            for (int i = 0; i < str.Length-1; i++)
                if (str.ToString(i, 1)==" " && str.ToString(i+1,1) != " ") count++;   
                
            
            Console.WriteLine($"Number of words: {count+1}");*/
            // ====================================================
            // ================== Task 7 ==========================
            /*            StringBuilder str = new StringBuilder();
                        Console.Write("Enter the line: ");
                        str = str.Append(Console.ReadLine());
                        int j = 0; 
                        int n = 0;

                        for (int i = 0; i < str.Length-1; i++)
                            {

                            if (str.ToString(i, 1) == " " && str.ToString(i + 1, 1) != " ")
                                {     
                                for (j = i-1; j >n-1 ; j--) Console.Write(str.ToString(j, 1));
                                if (n==0) Console.Write(" "); // на первом слове добавляем пробел
                                n = i;
                                }

                            }
                        // Последнее слово
                        for (int i = str.Length; i > n; i--)
                        {
                            Console.Write(str.ToString(i-1, 1));
                        }
                        Console.WriteLine();
                        Console.WriteLine(str);
            */
            // ====================================================
            // ================== Task 8 ==========================

            /* string str = "aAuUeEoOyY"; // гласные буквы
             Console.Write("Enter a suggestion: ");
             string strEnter = Console.ReadLine();
             int count = 0;
             for (int i = 0; i < str.Length; i++)
             {
                 for (int j = 0; j < strEnter.Length; j++)
                 {
                     if (str[i] == strEnter[j]) count++;
                 }
             }
             Console.WriteLine( $"Count Vowels: {count}");*/


            // ====================================================
            // ================== Task 9 ==========================
            StringBuilder strEnter = new StringBuilder();
            Console.Write("Enter source string: ");
            strEnter = strEnter.Append(Console.ReadLine());
            Console.Write("Enter source string search: ");
            string strSearch = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < strEnter.Length-strSearch.Length; i++)
            {
                if (strEnter.ToString(i, 3) == strSearch) count++;
            }

            Console.WriteLine($"Search result: {count}");

            // ====================================================

        }
    }
}

