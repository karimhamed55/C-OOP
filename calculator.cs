using System;

namespace C_OOP
{
    public class ClsCalculator
    {
        public static int X1 = 0;
        public int Y1 { get; set; }
        public int OperationSaver;

        public void Add(int y1)
        {
            this.Y1 = y1;
            X1 = X1 + y1;
            OperationSaver = 1;
        }

        public void Subtract(int y1)
        {
            this.Y1 = y1;
            X1 = X1 - y1;
            OperationSaver = 2;
        }

        public void Multiply(int y1)
        {
            this.Y1 = y1;
            X1 = y1 * X1;
            OperationSaver = 3;
        }

        public void Divide(int y1)
        {
            this.Y1 = y1;
            if (y1 != 0)
                X1 = X1 / y1;
            OperationSaver = 4;
        }

        public void Clear()
        {
            X1 = 0;
            OperationSaver = 5;
        }

        public void PrintResult()
        {
            switch (OperationSaver)
            {
                case 1:
                    Console.WriteLine($"Result after adding {Y1} is {X1}");
                    break;
                case 2:
                    Console.WriteLine($"Result after subtracting {Y1} is {X1}");
                    break;
                case 3:
                    Console.WriteLine($"Result after multiplying {Y1} is {X1}");
                    break;
                case 4:
                    Console.WriteLine($"Result after dividing {Y1} is {X1}");
                    break;
                case 5:
                    Console.WriteLine($"Result after clear is {X1}");
                    break;
            }
        }
    }
}
