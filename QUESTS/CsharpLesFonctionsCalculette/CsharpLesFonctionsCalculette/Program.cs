using System;
using System.Data;
using System.Runtime.InteropServices;

namespace CsharpLesFonctionsCalculette
{
    class Program
    {
        public static decimal Add(decimal a, decimal b)
        {
            return (a + b);
        }
        public static decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }
        public static decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }
        public static decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }
        public static int Modulo(int a, int b)
        {
            return (a % b);
        }

        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter first operand");
                string firstOperand=Console.ReadLine();
                Console.WriteLine("Enter second operand");
                string secondOperand = Console.ReadLine();
                Console.Write("Wich operation you choose:");
                string operation=Console.ReadLine();
                Console.WriteLine("Operand you choose: {0}",operation);
                
                if (operation == "Add")
                {
                    decimal result = Add(decimal.Parse(firstOperand), decimal.Parse(secondOperand));   
                    Console.WriteLine("{0}+{1}={2}",firstOperand,secondOperand,result);
                }
                else if (operation == "Subtract")
                {
                    decimal result = Subtract(decimal.Parse(firstOperand), decimal.Parse(secondOperand));
                    Console.WriteLine("{0}-{1}={2}", firstOperand, secondOperand, result);
                }
                else if (operation == "Divide")
                {
                    decimal result = Divide(decimal.Parse(firstOperand), decimal.Parse(secondOperand));
                    Console.WriteLine("{0}/{1}={2}", firstOperand, secondOperand, result);
                }
                else if (operation == "Multiply")
                {
                    decimal result = Multiply(decimal.Parse(firstOperand), decimal.Parse(secondOperand));
                    Console.WriteLine("{0}*{1}={2}", firstOperand, secondOperand, result);
                }
                else if (operation == "Modulo")
                {
                    Int32 resultInt= Modulo(Convert.ToInt32(firstOperand), Convert.ToInt32(secondOperand));
                    Console.WriteLine("{0}%{1}={2}", firstOperand, secondOperand, resultInt);
                }
                else 
                {
                    Console.WriteLine("Unknown operation '{0}'", operation);
                }
                
            }
        }

        
        
        
    }
}
