using ShapesInheritanceExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Triangle : Shape
    {
        protected int size;
        public Triangle(Color colour, int x, int y, int size) : base(colour, x, y)
        {
            this.size = size;
        }

        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            Point[] points = { new Point(x, y + size), new Point(x + size / 2, y), new Point(x + size, y + size) };
            g.FillPolygon(b, points);
            g.DrawPolygon(p, points);
            base.draw(g);
        }
         public override float calcArea()
          {
              return (size * size)/2;
          }
    }
}
