
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace OOPCONCEPT
{
        public class Animal
        {
            public String Name;
            public void display()
            {
                Console.WriteLine("I am an animal");
            }
        }
       public class Dog : Animal
        {
            public void getName()
            {
                Console.WriteLine("My Name is" + Name);
            }
        }
    }






