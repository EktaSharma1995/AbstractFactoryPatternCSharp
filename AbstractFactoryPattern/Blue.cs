using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Blue: Color
    {
        public void fill()
        {
            Console.WriteLine("Blue");
        }
    }
}
