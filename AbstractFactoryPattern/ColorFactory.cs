using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ColorFactory: AbstractFactory
    {
        public override Shape getShape(string shapeType)
        {
             return null;

        }

        public override Color getColor(string colorType)
        {
            if (colorType == null)
            {
                return null;
            }

            if (colorType.Equals("BLUE"))
            {
                return new Blue();
            }
            else if (colorType.Equals("RED"))
            {
                return new Red();
            }
            else if (colorType.Equals("GREEN"))
            {
                return new Green();
            }

        
            return null;
        }
    }
        
}
