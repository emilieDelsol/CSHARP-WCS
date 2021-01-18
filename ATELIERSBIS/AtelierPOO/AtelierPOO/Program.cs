using System;
using System.Collections.Generic;

namespace AtelierPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Enterprise myEnterpise = new Enterprise();
            Console.WriteLine("My enterprise name is {0}", myEnterpise.GetEnterpriseName());
            while (true)
            {
                
                myEnterpise.Choice();
                

            }
        }
    }
    class Employe
    {
        private string _name;
        private double _salaire;

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }

        public double GetSalaire()
        {
            return _salaire;
        }
        public void SetSalaire(double salaire)
        {
            _salaire = salaire;
        }

        public Employe(string name, double salaire)
        {
            _name = name;
            _salaire = salaire;
        }
    }
    class Enterprise
    {
        private string _nameEnterprise = "Wild code school";
        private List<Employe> employeTable = new List<Employe>();

        public string GetEnterpriseName()
        {
            return _nameEnterprise;
        }
        

        public void HireEmploye()
        {
            Console.WriteLine("enter employe name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter salary!");
            double salaire = Convert.ToDouble(Console.ReadLine());
            var employe = new Employe( name, salaire);
            employeTable.Add(employe);

        }

        public void FireEmploye(Employe employe)
        {
            
            Console.WriteLine($" {employe.GetName()} is fired!! ");
            employeTable.Remove(employe);
        }

        public void Choice()
        {
            Console.WriteLine("\n******************************" +
                "\nWhat do you want to do? " +
                    "\nHired employe? -> type '+' " +
                    "\nFired employe? -> type '-' " +
                    "\nList name of employees? -> Type 'listName' " +
                    "\nList name with salary of employees -> Type 'listS'"+
                    "\nAverage salary? -> Type 'average'" +
                    "\n*******************************");
            string userChoice = Console.ReadLine();
            if (userChoice == "+")
            {
                Console.WriteLine("\n*****How many employees do you want to hire? *****");
                int userChoiceNumber=Convert.ToInt32(Console.ReadLine());
                for (int i =0; i<userChoiceNumber; i++)
                {
                    HireEmploye();
                }
                
            }
            else if (userChoice == "-")
            {
                Console.WriteLine("*****Type the name of the employe you whant to fire: *****");
                string name = Console.ReadLine();

                foreach (Employe value in employeTable)
                {
                    if (value.GetName() == name)
                    {
                        FireEmploye(value);
                    }
                }
            }
            else if (userChoice== "listName")
            {
                foreach(Employe employe in employeTable)
                {
                    Console.WriteLine($"**************************************** \n {employe.GetName()} \n");
                }
            }
            else if (userChoice == "listS")
            {
                foreach (Employe employe in employeTable)
                {
                    Console.WriteLine($"**************************************** \n {employe.GetName()} , salary = {employe.GetSalaire()}\n");
                }
            }
            else if (userChoice == "average")
            {
                double sum = 0;
                double count = 0;
                foreach(Employe employe in employeTable)
                {
                    sum = sum + employe.GetSalaire();
                    count++;
                }
                Console.WriteLine($"*******************************************\nAverage salary of the company is {sum/count} €");
            }
        }
    }
}
