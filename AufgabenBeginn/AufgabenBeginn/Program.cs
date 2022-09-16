using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Uebungen
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Geben sie eine Zahl ein");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie eine Operator ein (+, -, *, /, %, %%)");
            string op  = Console.ReadLine();

            Console.WriteLine("Geben sie eine Zahl ein");
            int number2 = Convert.ToInt32(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
                    break;
                case "*":
                    Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
                    break;
                case "/":
                    if(number1==0 || number2 == 0)
                    {
                        Console.WriteLine($"{number1} / {number2} = 0");
                    }
                    else
                    {
                        Console.WriteLine($"{number1} / {number2} = {(float)number1 / (float)number2}");
                    }
                    break;
                case "%":
                    Console.WriteLine($"{number1} % {number2} = {(float)number1 * ((float)number2 /100)}");
                    break;
                case "%%":
                    Console.WriteLine($"{number1} %% {number2} = {(float)number1 % (float)number2}");
                    break;

            }

            Console.ReadKey();
        }     
    }
}
