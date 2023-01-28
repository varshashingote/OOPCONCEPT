using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCONCEPT
{
  
        class Principal
        {
            public void Monitor()
            {
                Console.WriteLine("Monitor");
            }
        }
        class Teacher : Principal
        {
            public void Teach()
            {
                Console.WriteLine("Teach");
            }
        }
        class Student : Principal
        {
            public void Learn()
            {
                Console.WriteLine("Learn");
            }


        }
    }
