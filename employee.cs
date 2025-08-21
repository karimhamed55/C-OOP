using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class employee : person
    {
       public int empID { get; set; }
       public string empcompany {  get; set; }

        public employee(int id , string name , int age , int empID, string empcompany):base(id ,name , age)
        {
            this.empID = empID;
            this.empcompany = empcompany;
        }
        public override void saymyname()
        {
            Console.WriteLine("the is from the inherited employee class....");
        }
    }
}
