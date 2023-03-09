using Laba4OOP.src;
using System.Drawing;

namespace Laba4OOP
{
    public partial class Form1 : Form
    {
        ShapeContainer shapeContainer = new ShapeContainer();
        Graphics field;
        Bitmap map;
        public Form1()
        {
            InitializeComponent();
            map = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            field = Graphics.FromImage(map);
            shapeContainer.drawAll();
            pictureBox1.Image = map;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //todo мб добавить билдер
            shapeContainer.AddOrSelectShape(new CCircle(15, e.X, e.Y, field));
            pictureBox1.Invalidate();
        }
    }
}