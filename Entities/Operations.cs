using System;
using System.Globalization;

namespace CalculatorWUI.Entities
{
    internal class Operations
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operation { get; set; }

        public Operations()
        {
            Number1 = 0;
            Number2 = 0;
            Operation = String.Empty;
        }

        public Operations(int number1, int number2, string operation)
        {
            Number1 = number1;
            Number2 = number2;
            Operation = operation;
        }
     
        public double Operator()
        {  
            return Operation switch
            {
                "+"  => Number1 + Number2,
                "-"  => Number1 - Number2,
                "*"  => Number1 * Number2,
                "/"  => Number1 / Number2,
                "+%" => Number1 + (Number1 * (Number2 / 100)),
                "-%" => Number1 - (Number1 * (Number2 / 100)),
                _ => 0.00,
            };            
        }
        
        public string StrOperations()
        {
            return Operation switch
            {
                "+" => "Sum",
                "-" => "Subtraction",
                "*" => "Multiplication",
                "/" => "Division",
                "+%" => "Sum Percentage",
                "-%" => "Subtraction Percentage",
                _ => "",
            };
        }

        public override string ToString()
        {

            return "Operation: " + StrOperations() 
                + '\n'
                + "Result: " + Operator().ToString("0,0.00", CultureInfo.InvariantCulture);
        }

    }
}

