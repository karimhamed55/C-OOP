using System;

namespace C_OOP
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int NumOfCars;

        public Car()
        {
            NumOfCars++;
        }

        public void ShowCarsData()
        {
            Console.WriteLine($"The id is {this.Id} and the name is {this.Name}");
        }

        public static void ShowNumOfCars()
        {
            Console.WriteLine($"The number of cars is {NumOfCars}");
        }
    }
}
