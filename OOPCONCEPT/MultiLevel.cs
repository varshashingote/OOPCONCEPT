using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCONCEPT
{

    public class GrandParent
    {
        public string Name;
        public void printName()
        {
            Console.WriteLine("I am GrandParent" + Name);
        }
    }
    public class Father : GrandParent
    {
        public string Name2;
        public void setName()
        {
            Console.WriteLine("I am Father" + Name2);
        }
    }
    public class child : Father
    {
        public string Name3;
        public void getName()
        {
            Console.WriteLine("I am child" + Name3);
        }
    }
}

