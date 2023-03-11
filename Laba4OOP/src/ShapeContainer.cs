using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src
{
    class ShapeContainer
    {
        private List<Shape> shapes;
        public ShapeContainer() { 
            shapes= new List<Shape>();
        }

        public void AddOrSelectShape(Shape shape)
        {
            unSelectAll();
            if (isSelect(shape.getPosition())) { return; }
            shape.changeSelect();
            shapes.Add(shape);
        }

        public void drawAll()
        {
            foreach (Shape shape in shapes)
                shape.draw();
        }

        public bool isSelect(Point point)
        {
            bool res = false;
            foreach(Shape shape in shapes)
            {
                res = shape.checkPointPosition(point) || res;
            }
            return res;
        }

        public void unSelectAll()
        {
            foreach(Shape shape in shapes)
            {
                shape.unSelect();
            }
        }
    }
}
