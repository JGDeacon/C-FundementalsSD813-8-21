using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceClasses
{
    public class Kitchen : House
    {
        public Kitchen()
        {
            SquareFeet = 500;
            TypeOfFlooring = FlooringType.Carpet;
        }
    }
}
