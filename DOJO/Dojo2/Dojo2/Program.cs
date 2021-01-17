using System;

namespace Dojo2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Entrez un nombre :");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrez un second nombre :");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Choisissez l'opération :");
                string operand = Console.ReadLine();

                Calculator calculator = new Calculator();

                if (operand == "+")
                {
                    Console.WriteLine("Le résultat de {0} + {1} = {2}", number1, number2, calculator.Add(number1, number2));
                }
                else if (operand == "-")
                {
                    Console.WriteLine("Le résultat de {0} - {1} = {2}", number1, number2, calculator.Sub(number1, number2));
                }
                else if (operand == "*")
                {
                    Console.WriteLine("Le résultat de {0} * {1} = {2}", number1, number2, calculator.Mul(number1, number2));
                }
                else if (operand == "/")
                {
                    Console.WriteLine("Le résultat de {0} / {1} = {2}", number1, number2, calculator.Div(number1, number2));
                }
                else
                {
                    Console.WriteLine("Entrez un opérateur valide :");
                }
            }

        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public float Div(int a, int b)
        {
            return (float)a / b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
}
