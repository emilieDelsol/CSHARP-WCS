using NUnit.Framework;
using SalaryCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorTest
{
    public class TestCompany
    {
        [Test]
        public void TestCompanyWithEmployeesWeekly()
        {
            Company company = new Company { Name = "Test" };
            company.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Assert.AreEqual(700.0d, company.WeeklySalaryExpenditures,
                            "A company with two employees earning 350.0 $ should spend 700.0 $ each week");
        }
        [Test]
        public void TestCompanyWithEmployeesDaily()
        {
            Company company = new Company { Name = "Test" };
            company.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Assert.AreEqual(140.0d, company.DailySalaryExpenditures,
                            "A company with two employees earning 70.0 $ should spend 140.0 $ each year");
        }
        [Test]
        public void TestCompanyWithEmployeesMonthly()
        {
            Company company = new Company { Name = "Test" };
            company.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Assert.AreEqual(2800, company.MonthlySalaryExpenditures,
                            "A company with two employees earning 1 400.0 $ should spend 2 800.0 $ each month");
        }

        [Test]
        public void TestCompanyWithEmployeesYearly()
        {
            Company company = new Company { Name = "Test" };
            company.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Assert.AreEqual(33600.0d, company.YearlySalaryExpenditures,
                            "A company with two employees earning 1 400.0 $ should spend 33 600 $ each year"); 
        }   
    }
}
