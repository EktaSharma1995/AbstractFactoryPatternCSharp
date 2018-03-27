using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("I am a rectangle");
        }
    
    }
}
