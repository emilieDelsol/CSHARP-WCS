using NUnit.Framework;
using SalaryCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorTest
{
	class TestCalculator
	{
        [Test]
        public void TestCompanieWithEmployeesMonthly()
        {
            Calculator calculator = new Calculator { Name = "calculator test" };
            Company company1 = new Company { Name = "company 1" };
            company1.Employees = new List<Employee>
            {
                new Employee { Name = "EmplyeeCompany1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Employe2Company1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Company company2 = new Company { Name = "company 2" };
            company2.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            calculator.Companies = new List<Company>
            {
                company1,company2
            };
            Assert.AreEqual(5600.0d, calculator.MonthlyCompaniesExpenditures,
                         "2 companies with two employees earning 1 400.0 $ should spend 5600.0 $ each year");

        }
            [Test]
        public void TestCompaniesWithEmployeesYearly()
        {
            Calculator calculator = new Calculator { Name = "calculator test" };
            Company company1 = new Company { Name = "company 1" };
            company1.Employees = new List<Employee>
            {
                new Employee { Name = "EmplyeeCompany1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Employe2Company1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Company company2 = new Company { Name = "company 2" };
            company2.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            calculator.Companies = new List<Company>
            {
                company1,company2
            };
            Assert.AreEqual(67200.0d, calculator.YearlyCompaniesExpenditures,
                         "2 companies with two employees earning 1 400.0 $ should spend 67200.0 $ each year");
        }

    }
}
