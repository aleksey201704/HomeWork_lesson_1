using System;
using System.Collections.Generic;

namespace HomeWork_lesson_1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK_1");
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("being right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            //=================            TASK_2       ================================
/* Console.WriteLine("TASK_2");

 int ProductNumber=1;
 int MinNumber = 0;
 int MaxNumber = 0;

 int n=0;

 for (int count = 0; count < 5; count++)
 {
     n = int.Parse(Console.ReadLine());
     if (count == 0) { ProductNumber = n; MinNumber = n; MaxNumber = n; }
     if (count > 0) ProductNumber = ProductNumber * n;
     if (MinNumber > n) MinNumber = n; 
     if (MaxNumber < n) MaxNumber = n; 
 }

 Console.WriteLine($"Product Number: {ProductNumber}");
 Console.WriteLine($"Minimun Number: {MinNumber}");
 Console.WriteLine($"Minimun Number: {MaxNumber}");*/
//=================          TASK_3         =================================
/*Console.WriteLine("TASK_3");

string StrNumber = Console.ReadLine();

for (int i = StrNumber.Length; i > 0; i--)
{
    Console.Write(StrNumber[i-1]);
}*/
//=================          TASK_4        =================================
/*Console.WriteLine("TASK_4");
int OneNumber = int.Parse(Console.ReadLine());
int TwoNumber = 0;
int NumElemets = 0;
List<int> Fibo = new List<int> {};
Fibo.Add(0);
Fibo[0] = 1;
Fibo.Add(1);
Fibo[1] = 1;
while (true)
{
    TwoNumber = int.Parse(Console.ReadLine());
    if (OneNumber < TwoNumber)  break;
    Console.WriteLine("Enter more than the first number");
}
NumElemets = TwoNumber - OneNumber; // Количество эелемнтов
if (OneNumber == 0 || OneNumber == 1) { OneNumber = 2; Console.Write("1 "); Console.Write("1 "); }
if (OneNumber==2) Console.Write("2 ");

for (int i = 2; i < NumElemets; i++)
{
    Fibo.Add(i);
    Fibo[i] = Fibo[i - 1] + Fibo[i - 2];

    if (Fibo[i] >= TwoNumber) break;
    if (Fibo[i] > OneNumber) Console.Write($"{Fibo[i]} ");

}*/

//=================          TASK_5       =================================
/*Console.WriteLine("TASK_5");
int NomerA = 0;
int NomerB = 0;

while (true)
{
Console.Write("Input A: ");
NomerA = int.Parse(Console.ReadLine());
    if (NomerA > 0) break; else Console.WriteLine("Enter number A, please");
}

while (true)
{
    Console.Write("Input B: ");
    NomerB = int.Parse(Console.ReadLine());
    if (NomerB > 0 && NomerB > NomerA) break; else Console.WriteLine("Enter number B, please");
}

for(int n=NomerA; n < NomerB+1; n++)
{
    for (int i = 0; i < n; i++)
    {
    Console.Write(n +" ");
    }
    Console.WriteLine();
}*/

//=================          TASK_6       =================================
            Console.WriteLine("TASK_6");
            Console.Write("Enter Line Length: ");
            int LineLen = int.Parse(Console.ReadLine());
            
            Console.Write("Enter PlaceHolder character: ");
            string PlaceHolder = Console.ReadLine();

            // Напрваление линии
            int LineDirection = 0;
            while (true)
            {
                Console.Write("Enter LineDirection 1-Horizontally, 0 - Vertically : ");
                LineDirection = int.Parse(Console.ReadLine());
                if (LineDirection == 1 || LineDirection == 0) break;
            }

            if (LineDirection==0)
            {
                for (int i = 0; i < LineLen; i++) Console.WriteLine(PlaceHolder);
                
            }

            if (LineDirection == 1)
            {
                for (int i = 0; i < LineLen; i++) Console.Write(PlaceHolder);

            }







        }
    }
}
