using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4OOP.src
{
    class CCircle : Shape
    {
        protected int radius;
        protected Point position;
        protected Boolean selected;
        Graphics field;

        public CCircle(int radius, int x, int y, Graphics graphics)
        {
            this.radius = radius;
            this.position = new Point(x,y);
            this.field = graphics;
        }

        public void draw()
        {
            Pen pen;
            if (selected) { pen = new Pen(Color.Blue, 2); }
            else { pen = new Pen(Color.Black, 2); }

            field.DrawEllipse(pen, position.X - radius, position.Y - radius, radius * 2, radius * 2);
        }

        public void changeSelect()
        {
            selected = !selected;
        }

        public bool checkPointPosition(Point point)
        {
            double len = Math.Sqrt(Math.Pow(point.X - position.X, 2) + Math.Pow(point.Y - position.Y, 2));
            if(len < radius)
            {
                selected = true;
                return true;
            }
            return false;
        }

        public Point getPosition()
        {
            return position;
        }

        public  void unSelect()
        {
            selected = false;
        }
    }
}
