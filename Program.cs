using System;
using System.Dynamic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();

            double firstfigure = Convert.ToDouble(a);

            string b = Console.ReadLine();

            double secondfigure = Convert.ToDouble(b);

            string c = Console.ReadLine();

            double thirdfigure = Convert.ToDouble(c);

            double sum = firstfigure + secondfigure + thirdfigure;

            double multiplication = firstfigure * secondfigure * thirdfigure;

            Console.WriteLine("Cумма трех чисел: " + sum);
            Console.WriteLine("Произведение трех чисел: " + multiplication);
            Console.WriteLine("Произведение трех чисел: " + multiplication);

        }
    }
}


   