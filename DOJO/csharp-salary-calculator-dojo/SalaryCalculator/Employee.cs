using System;

namespace SalaryCalculator
{
    public class Employee
    {
        public String Name { get; set; }
        public Double HourlySalary { get; set; }
        /// <summary>
        /// Period of hours worked in one week
        /// </summary>
        public Int32 WeekTimePeriodWorked { get; set; }

        public Double WeeklySalary
        {
            get
            {
                return HourlySalary * WeekTimePeriodWorked ;
            }
        }

        public Double DailySalary
        {
            get 
            {
                return HourlySalary * WeekTimePeriodWorked / 5;
            }
        }

        public double MonthlySalary 
        { 
            get
            {
                return HourlySalary*WeekTimePeriodWorked * 4;
            }
        }

		public double YearlySalary 
        {
			get
			{
                //taux horaire 10 /h
                // 35h / semaine
                // 1 mois = 4 semaines 
                // 1 année 12 mois 
                //salaire à la semaine => 35*10 = 350
                // salaire au mois  = > 350*4=1400
                //salaire à l'année => 1400 * 12 
               return MonthlySalary * 12;
			} 
        }
	}
}
