using System;

namespace CarShop
{
    class Program
    {
        public class CarShop
        {
            public int carsCount;
            public string address;
            public int vendorsCount;
            public float totalMoney;

            public void SellOneCar()
            {
                if (vendorsCount > 0 && carsCount > 0)
                {
                    vendorsCount = vendorsCount - 1;
                    carsCount = carsCount - 1;
                    totalMoney = totalMoney + 100000;
                    vendorsCount = vendorsCount + 1;
                    Console.WriteLine("You have selled one car. Your now have " + totalMoney + " $");
                }
                else
                {
                    Console.WriteLine("No vendor is free, you can not sell a new car ...");
                }
            }

            public void FireVendors(int firedVendorsCount)
            {
                if (vendorsCount - firedVendorsCount >= 0)
                {
                    vendorsCount = vendorsCount - firedVendorsCount;
                    totalMoney = totalMoney + (firedVendorsCount * 1000);
                    Console.WriteLine("You have fired " + firedVendorsCount + " vendors. You now have " + vendorsCount + " vendors.");
                }
                else
                {
                    Console.WriteLine("Please stay reasonable, you can not fire much more vendors that you already employ !");
                }
            }

            public void HireVendors(int employedVendorsCount)
            {
                if (totalMoney - (employedVendorsCount * 1000) >= 0)
                {
                    vendorsCount = vendorsCount + employedVendorsCount;
                    totalMoney = totalMoney - (employedVendorsCount * 1000);
                    Console.WriteLine("You hired " + employedVendorsCount + " new vendors. You now have " + vendorsCount + " vendors in your team.");
                }
                else
                {
                    Console.WriteLine("Insufficient money to employ " + employedVendorsCount + " vendors.");
                }
            }

            public void BuyOneCar()
            {
                if (totalMoney >= 50000)
                {
                    carsCount = carsCount + 1;
                    totalMoney = totalMoney - 50000;
                    Console.WriteLine("You now have " + carsCount + " cars but you spent 50 000 $ to buy it.");
                }
                else
                {
                    Console.WriteLine("Insufficient funds to buy a car.");
                }
            }
        }

        static void Main(string[] args)
        {
            CarShop carShop = new CarShop();
            carShop.totalMoney = 51000; // Enough money to hire an employee and buy a car
            carShop.HireVendors(1); // Hiring one vendor
            carShop.BuyOneCar(); // Buying a car
            carShop.SellOneCar(); // Selling the car bough
        }
    }
}
