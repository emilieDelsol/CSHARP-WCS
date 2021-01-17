using NUnit.Framework;
using SalaryCalculator;

namespace SalaryCalculatorTest
{
    public class TestEmployee
    {
        [Test]
        public void TestEmployeeWeeklySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };

            Assert.AreEqual(350.0d, employee.WeeklySalary,
                            "An employee earning 10.0 $ hourly working 35 hours a week earns 350.0 $ per week.");
        }

        [Test]
        public void TestEmployeeDailySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };
            Assert.AreEqual(70.0d, employee.DailySalary,
                            "An employee earning 10.0 $ per hour working 35 hours a week earns 70.0 $ per day");
        }
        
        [Test]
        public void TestEmployeeMonthlySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };
            Assert.AreEqual(1400.0d, employee.MonthlySalary,
                            "An employee earning 10.0 $ per hour working 35 hours a week earns 1400.0 $ per month");
        }
        [Test]
        public void TestEmployeeYearlySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };
            Assert.AreEqual(16800.0d, employee.YearlySalary,
                            "An employee earning 10.0 $ per hour working 35 hours a week earns 1400.0 $ per month");
        }
    }
}