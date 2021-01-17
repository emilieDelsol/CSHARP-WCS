using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculator
{
    public class Company
    {
        public String Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

        /// <summary>
        /// Total of employees salary per month
        /// </summary>
        public Double MonthlySalaryExpenditures 
        {
            get
            {
                // Pour chaque employé dans ma liste Employees 
                // Faire la somme de tous les salaires des employés par mois
                double sum = 0; 
                //  salaireMoisEmployé1 + salaireMoisEmployé2 = > salaires par mois de l'entreprise
                // employé1.MonthlySalary + employé2.MonthlySalary

                foreach(Employee employe in Employees)
				{
                    sum = sum + employe.MonthlySalary;
				}
                //return sum;
                return Employees.Sum(employe => employe.MonthlySalary);
            }
        }

        /// <summary>
        /// Total of employees salary per year
        /// </summary>
        public Double YearlySalaryExpenditures 
        {
            get
            {
                return Employees.Sum(e => e.MonthlySalary * 12);
            }
        }

		public double DailySalaryExpenditures 
        { 
            get 
            {
                return Employees.Sum(e => e.DailySalary);
            } 
        }

		public double WeeklySalaryExpenditures 
        {
            get 
            {
                return Employees.Sum(e => e.WeeklySalary);
            }  
        }
	}
}
