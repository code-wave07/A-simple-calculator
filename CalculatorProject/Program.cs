// See https://aka.ms/new-console-template for more information
using System;

namespace MyCalculator 
{
    class Calculator
    {
        static void Main(string[] args) 
        {
	    Console.WriteLine("Hello, User!");
	    Console.WriteLine("Welcome to the calculator");
						
            double x;
            double y;
            double answer;

            Console.WriteLine("Input you first number.");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input your second number");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("what do you want to do?\n *: multiply, /: division, +: addition, -: subtraction");
            var option = Console.ReadLine();

            switch(option)
                {
                case "*":
                    answer = multiply(x,y);
                    Console.WriteLine(answer);
                break;

                case "/":
                    answer = division(x,y);
                    Console.WriteLine(answer);
                break;

                case "+":
                    answer = addition(x, y);
                    Console.WriteLine(answer);
                break;

                case "-":
                    answer = subtraction(x, y);
                    Console.WriteLine(answer);
                break;

                default:
                    Console.WriteLine("invalid operator");
                break;
                }
        }

        static double multiply(double x,double y)
        {
            double z = x * y;
            return z;
        }

        static double addition(double x, double y)
        {
            double z = x + y;
            return z;
        }

        static double subtraction(double x, double y)
        {
            double z = x - y;
            return z;
        }

        static double division(double x, double y)
        {
            double z = x / y;
            return z;
        }
    }
}

