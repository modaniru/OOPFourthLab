using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src.utils
{
    interface ShapeFactory
    {
        Shape createShape(int x, int y);
    }
}
