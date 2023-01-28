using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCONCEPT
{
   
        public interface Drawable
        {
            void draw();
        }
        public class Rectangle1 : Drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        public class Circle1 : Drawable
        {
            public void draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
}





