//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_3._2
{
    internal class Program

    {   //Task2: Обчислення суми ряду

        static void SumRyadu ()
        {
           double x = -0.5;          
           double epsilon = 1e-3;  
           double sum = 0.0;
           double term;
           int n = 1;                 
           double factorial = 0;


            do
            {

                term = Math.Pow(x, n) / factorial;
                sum += term;

                Console.WriteLine($"Ітерація {n}: Поточний член = {term}, Сума = {sum}");

                n++;
                factorial++;
 

            } while (Math.Abs(term / sum) >= epsilon);

            Console.WriteLine($"Накопичена сума ряду S1 = {sum} після {n} ітерацій");

            Console.WriteLine("\nВиконуємо обчислення суми ряду (Завдання 2):");
            SumRyadu();







        }
    }
}
