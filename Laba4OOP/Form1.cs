using Laba4OOP.src;
using Laba4OOP.src.utils;
using System.Drawing;

namespace Laba4OOP
{
    public partial class Form1 : Form
    {
        ShapeContainer shapeContainer = new ShapeContainer();
        Graphics field;
        ShapeFactory factory;
        Bitmap map;
        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            factory = new CCircleFactory(Graphics.FromImage(map));
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            shapeContainer.drawAll();
            pictureBox1.Image = map;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //todo мб добавить билдер
            shapeContainer.AddOrSelectShape(factory.createShape(e.X, e.Y));
            pictureBox1.Invalidate();
        }
    }
}