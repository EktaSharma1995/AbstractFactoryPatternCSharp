using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Circle: Shape
    {
        public void draw()
        {
            Console.WriteLine("I am a circle");
        }
    }
}
