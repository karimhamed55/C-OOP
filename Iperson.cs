using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal interface Iperson
    {
        string Name { get; set; }
        string Description { get; set; }
         int age {  get; set; }
        void introduce();
    }
}
