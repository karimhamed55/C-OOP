using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP
{
    internal class database
    {
        public int id;
        public string name;
        public int password;

        public database(int id , string name , int password)
        {
            this.id = id;
            this.name = name;
            this.password = password;
        }
        public static database find (int id)
        {
            if (id == 10)
                return new database(10, "karim", 55);
            else
                return null;
        }
        public static database find(string name, int password)
        {
            if ( name =="karim" && password==5)
                return new database(10, "karim", 55);
            else
                return null;
        }

    }
}
