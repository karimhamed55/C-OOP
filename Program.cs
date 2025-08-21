using System;
using System.Diagnostics.Eventing.Reader;
using _3rdOOPtasks;
using C_OOP;

namespace C_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car demo
            Car car1 = new Car { Id = 1, Name = "Ford" };
            Car car2 = new Car { Id = 2, Name = "Lambo" };
            Car car3 = new Car { Id = 3, Name = "Toyota" };

            car1.ShowCarsData();
            car2.ShowCarsData();
            car3.ShowCarsData();
            Car.ShowNumOfCars();

            // Calculator demo
            ClsCalculator calc1 = new ClsCalculator();
            calc1.Add(29);
            calc1.PrintResult();

            calc1.Multiply(2);
            calc1.PrintResult();

            calc1.Clear();
            calc1.PrintResult();

            // person demo
            // find by id
            database user1 = database.find(10);
            if (user1 != null)
                Console.WriteLine("the user is found");
            else
                Console.WriteLine("the user is not found");
            // find by user and pass
            database user2 = database.find("karim", 56);
            if (user2 != null)
                Console.WriteLine("the user is found");
            else
                Console.WriteLine("the user is not found");

            // using person and employee
            employee emp1 = new employee(1, "mazen", 15, 01, "arabian");
            Console.WriteLine($"the employee name is {emp1.name} and his age is {emp1.age} works at {emp1.empcompany}");
            emp1.saymyname();

            // using human and abstract creature
            human hum = new human();
            hum.CreatureName();

            // using Iperson interface with Ikid

            Ikid ikid = new Ikid();
            ikid.Name = "hamoksha";
            ikid.age = 12;
            ikid.introduce();
            // using outer class
            OuterClass outer1 = new OuterClass(42);

            OuterClass.InnerClass inner1 = new OuterClass.InnerClass(100);

            outer1.OuterMethod(); 
            inner1.InnerMethod(); 
            inner1.AccessOuterVariable(outer1);

            point3d point1 = new point3d(5, 3, 6);
            point3d point2 = new point3d();
            point2.x = Convert.ToInt32(Console.ReadLine());
            point2.y = Convert.ToInt32(Console.ReadLine());
            point2.z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(point1.ToString());

            Console.WriteLine(point2.ToString());

            if (point1 == point2)
                Console.WriteLine("the two objects are equal");
            else
                Console.WriteLine("the two objects are not equal");

            point3d.arr = new point3d[] { point1, point2 };

            Array.Sort(point3d.arr);
            for (int i = 0; i < 2; i++)
                Console.WriteLine(point3d.arr[i].ToString());


            Duration D1 = new Duration(1, 45, 3);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());
            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString());
            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            Console.WriteLine("\n--- Operators ---");

            D3 = D1 + D2;
            Console.WriteLine("D3 = D1 + D2 → " + D3);

            D3 = D1 + 7800;
            Console.WriteLine("D3 = D1 + 7800 → " + D3);

            D3 = 666 + D3;
            Console.WriteLine("D3 = 666 + D3 → " + D3);

            D3 = ++D1;
            Console.WriteLine("D3 = ++D1 (add 1 minute) → " + D3);

            D3 = --D2;
            Console.WriteLine("D3 = --D2 (subtract 1 minute) → " + D3);



            // Comparisons
            Console.WriteLine("\n--- Comparisons ---");

            if (D1 > D2) Console.WriteLine("D1 is greater than D2");
            if (D1 <= D2) Console.WriteLine("D1 is less than or equal to D2");


            // DateTime
            Console.WriteLine("\n--- Casting ---");

            DateTime obj = (DateTime)D1;
            Console.WriteLine("DateTime from D1: " + obj);

        }
    }
}
