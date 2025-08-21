using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class Ikid : Iperson
    {
        public string Name { get; set; }
        public string Description { get; set; }
 public int age { get; set; }

        public  void introduce()
        {
            Console.WriteLine($"my name is {Name} and i am {age}");
        }
    }
}
