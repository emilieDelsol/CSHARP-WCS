using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculator
{
	public class Calculator
	{
		public string Name { get; set; }
		public IEnumerable<Company> Companies { get; set; }
		public double YearlyCompaniesExpenditures
		{
			get
			{
				return Companies.Sum(c => c.YearlySalaryExpenditures);
			}
		}

		public double MonthlyCompaniesExpenditures { 
			get
			{
				return Companies.Sum(c => c.MonthlySalaryExpenditures);
			}
				}
	}
}