using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory shapeFactory = FactoryProducer.getFactory("SHAPE");

            Shape shape1 = shapeFactory.getShape("CIRCLE");

            shape1.draw();

            AbstractFactory colorFactory = FactoryProducer.getFactory("COLOR");

            Color color1 = colorFactory.getColor("RED");

            color1.fill();

        }
    }
}
