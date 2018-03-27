using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ShapeFactory: AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
            if(shapeType == null)
            {
                return null;
            }   

            if(shapeType.Equals("CIRCLE")) {
                return new Circle();
            } else if (shapeType.Equals("RECTANGLE")) {
                return new Rectangle();
            } else if (shapeType.Equals("SQUARE")) {
                return new Square();
            }

            return null;

        }

        public override Color getColor(string colorType)
        { 
            return null;
        }
    }
}
