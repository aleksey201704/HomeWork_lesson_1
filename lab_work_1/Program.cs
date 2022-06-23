using System;
using System.Collections.Generic;
using System.Text;

namespace lab_work_1
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            //============================== Lab 5 ================================
            /*const int RAZMER = 5;
            int[,] arr = new int[RAZMER,RAZMER];
            Random rnd = new Random();
            int min, max,Summa=0;
            
            for (int i = 0; i < RAZMER; i++)
            {
                for (int j = 0; j < RAZMER; j++) arr[i, j] = rnd.Next(-100, 100);
            }
            min = arr[0, 0];
            max = arr[0, 0];

            for (int i = 0; i < RAZMER; i++)
            {
                for (int j = 0; j < RAZMER; j++)
                {
                    Console.Write(arr[i,j]+"\t");
                    if (min > arr[i, j]) min = arr[i, j];
                    if (max < arr[i, j]) max = arr[i, j];
                }
                Console.WriteLine();
            }

            for (int i = 0; i < RAZMER; i++)
            {
                for (int j = 0; j < RAZMER; j++)
                {
                    if (arr[i, j] > min && arr[i, j] < max) Summa = Summa + arr[i, j];
                }
            }
            
            Console.Write($"Min = {min} : Max = {max} : Сумма = {Summa} ");*/

            //=====================================================================
            //============================== Lab 3 4 ================================
            /*Console.Write("Введите строку: ");
            StringBuilder word = new StringBuilder(Console.ReadLine());
            StringBuilder reversword = new StringBuilder();
            //string reversword;
            int t, count = 0,n=0;
            t = word.Length - 1;
            
            for (int i = t; i > -1; i--) reversword.Append(word[i]);
            for (int i = 0; i < word.Length; i++)
            { 
                if (word[i] == reversword[i]) count++;
                if (word[i] == ' ' && word[i+1] != ' ') n++;
            }
            
            if (count == word.Length) Console.WriteLine("Палиндромом");
            Console.WriteLine($"Количество слов: {n+1}");*/

            //=====================================================================

            //============================== Lab 2 ================================
            /*int[] M = new int[10];
            int[] N = new int[10];
            int[] D = new int[20];
            
            List<int>W = new List<int>();
            int t = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++) M[i] = rnd.Next(10, 20);
            for (int i = 0; i < 10; i++) N[i] = rnd.Next(10, 20);
            for (int i = 0; i < 10; i++) Console.Write(M[i] + "\t");
            Console.WriteLine();
            for (int i = 0; i < 10; i++) Console.Write(N[i] + "\t");

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (M[i] == N[j]) 
                    {
                        D[t] = M[i];t++;
                        W.Add(M[i]);
                    }
                }
            }
                       
            
            Console.WriteLine();
            
            for (int i = 0; i < W.Count; i++)
            {
                
                for (int j = i+1; j < W.Count; j++)
                {
                    if (W[i] == W[j])
                    {
                       W.RemoveAt(j);
                       j--;
                    }
                    
                }
                
            }

            for (int i = 0; i < W.Count; i++)
            {
                Console.Write(W[i]+"\t");
            }
            

            Console.WriteLine();*/

            

            //=====================================================================

            //============================== Lab 1 ================================
            /*double[] arrA = new double[5];
            double[,] arrB = new double[3, 4]; // двухмерный массив
            var random = new Random();
            double rnd,summa=0;
            double multiplication = 1;
            double SummaA = 0;
            double SummaB = 0;



            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter {i + 1} number: ");
                string s = Console.ReadLine();
                arrA[i] = Convert.ToDouble(s);
            }

            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 1) SummaA = SummaA + arrA[i];
                Console.Write($"{arrA[i]} \t");              
            }
            
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    rnd=random.Next(1,20);
                    arrB[i,j] = random.NextDouble() * rnd;
                    arrB[i,j]=Math.Round(arrB[i, j],1);
                    Console.Write($"{arrB[i, j]} \t");
                    if (j % 2 == 0) Math.Round(SummaB = SummaB + arrB[i, j],1);
                }
                Console.WriteLine();
            }

            double min,max;
            min = arrA[0];
            max = arrA[0];
            for (int i = 0; i < 5; i++)
            {
                summa = summa + arrA[i];
                multiplication = multiplication * arrA[i];

            if (min > arrA[i]) min = arrA[i];
            if (max < arrA[i]) max = arrA[i];
            } 
            
            *//*Console.WriteLine($"minA = {min}");
            Console.WriteLine($"maxA = {max}");
            *//*
            Console.WriteLine();

            double minB = min;
            double maxB = max;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++) 
                {
                    summa = summa + arrB[i, j];
                    multiplication = multiplication * arrB[i, j];
                if (minB > arrB[i, j]) minB = arrB[i, j];
                if (maxB < arrB[i, j]) maxB = arrB[i, j];
                }

            }
            Console.WriteLine($"min A and B = {minB}");
            Console.WriteLine($"max A and B = {maxB}");
            Console.WriteLine($"Summa A and B = {summa}");
            Console.WriteLine($"Умножение A and B = {multiplication}");
            Console.WriteLine($"SummaA четные A  = {SummaA}");
            Console.WriteLine($"SummaB нечетные B  = {SummaB}");*/
            //========================================================================




        }
    }
}
