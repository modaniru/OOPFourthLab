using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src.utils
{
    class CCircleFactory : ShapeFactory
    {
        private Graphics graphics;

        public CCircleFactory(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Shape createShape(int x, int y)
        {
            return new CCircle(30, x, y, graphics);
        }
    }
}
