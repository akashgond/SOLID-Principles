using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov_Substitution_Principle
{
    //BadSqare inherits from Rectangle class
    internal class BadSquare : Rectangle
    {
        public double height  
        { get => base.width;
          set => base.width = base.length = value; 
        }

        public double width
        {
            get => base.length;
            set => base.length = base.width = value;
        }


    }
}
