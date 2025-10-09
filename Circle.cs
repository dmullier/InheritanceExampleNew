using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapesInheritanceExample
{
    class Circle : Shape
    {
        protected int radius;
        public Circle(Color colour, int x, int y, int radius) : base(colour, x, y)
        {

            this.radius = radius; //the only thingthat is different from shape
        }


        public override void draw(Graphics g)
        {

            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillEllipse(b, x, y, radius * 2, radius * 2);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);
            base.draw(g);
        }

        public  override float calcArea()
        {
            return (float) Math.PI * radius * radius;
        }
        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }

        public void circleOnly()
        {             Console.WriteLine("Circle only method");
        }
    }
}

