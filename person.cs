using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class person
    {
        public int id;
        public string name;
        public int age;
      
        public person (int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }
        public virtual void saymyname()
        {
            Console.WriteLine($"i am person type who is my name is {name}");
        }
    }
}
