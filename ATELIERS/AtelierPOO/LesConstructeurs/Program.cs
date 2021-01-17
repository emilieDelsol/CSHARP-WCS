using System;

namespace LesConstructeurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Construction myNewConstruction = new Construction();
            myNewConstruction.Contructor();
        }
    }
    public class Building
    {
        private double _height;
        private double _floor;

        public Building(double floor)
        {
            _height = 3 * floor;
        }
        public Building(double height, double floor)
        {
            _height = height;
            _floor = floor;
        }

        public double GetFloorMaxSize(double height, double floor)
        {
            return height / floor;
        }
        public double GetFloorCount()
        {
            return _floor;
        }
        public double GetSize()
        {
            return _height;
        }
        
    }
    public class Construction
    {
        public void Contructor()
        {
            Console.WriteLine("Do you know height and number of floor of your building? -> Type Y or N");

            string userAsk = Console.ReadLine();
            if (userAsk == "Y")
            {
                Console.Write("Enter height: ");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter number of floor: ");
                double floor = Convert.ToDouble(Console.ReadLine());
                Building building = new Building(height, floor);
                Console.WriteLine($"Your building height is {building.GetSize()}" +
                    $"\nYour building number of floor is {building.GetFloorCount()}");
                Console.WriteLine($"Your building floor max size is {building.GetFloorMaxSize(height, floor)}");
            }
            if (userAsk == "N")
            {
                Console.Write("Enter number of floor you whant: ");
                double floor = Convert.ToDouble(Console.ReadLine());
                Building buildingFloor = new Building(floor);
                Console.WriteLine($"Your building height is {buildingFloor.GetSize()}");
            }
        }
    }


}
