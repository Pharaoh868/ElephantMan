using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantMan
{
    internal class Elephant
    {
        public int earSize;
        public string name;

        public void  WhoAmI()
        {
            Console.WriteLine("My name is " + name);
            Console.WriteLine("My ears are " + earSize + " inches tall.");

        }

    }
}
