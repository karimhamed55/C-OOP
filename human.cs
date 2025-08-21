using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class human: creature
    {
        public override int legsnum {  get; set; }
        public override string name {  get; set; }

   
        public  override void  legscount()
        {
            Console.WriteLine(" two legs creature");
        }
        public override void  CreatureName()
        {
            Console.WriteLine(" a human is here ....");
        }
    }
}
