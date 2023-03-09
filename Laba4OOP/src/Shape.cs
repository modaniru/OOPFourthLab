using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src
{
    interface Shape
    {
        void draw();
        void changeSelect();
        public bool checkPointPosition(Point point);

        public Point getPosition();

        public void unSelect();
    }
}
