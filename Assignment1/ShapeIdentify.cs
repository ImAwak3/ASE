using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class ShapeIdentify
    {
        public Interface1 getShape(String input)
        {
            {
                if (input == "rectangle")
                {
                    return new Rectangle();
                }
                else if (input == "circle")
                {
                   return new Circle();
                }else if(input== "triangle")
                {
                    return new Triangle();
                }
                else if(input=="drawto"){
                    return new DrawTo();
                }
                return null;
            }
        }
    }
}
        
    