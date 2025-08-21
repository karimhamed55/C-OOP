using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal abstract class creature
    {
        public abstract int legsnum { get; set; }
        public abstract string name { get; set; }

        public abstract void legscount();
        public abstract void CreatureName();
    }
}
