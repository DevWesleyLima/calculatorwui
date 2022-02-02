using System;
using CalculatorWUI.Entities;

namespace CalculatorWUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calculator 
            Console.WriteLine("Welcome to your calculator program!!!");
            Console.WriteLine("*************************************");

            Console.Write("Type the 1st number:");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Type the operator:");
            string operation = Console.ReadLine();

            Console.Write("Type the 2nd number:");
            int number2 = int.Parse(Console.ReadLine());            

            Operations calculator = new Operations(number1, number2, operation);

            Console.WriteLine(calculator);

            //Do another operation

            //
        }
    }  
}
