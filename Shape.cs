using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapesInheritanceExample
{
    class Shape 
    {

        protected Color colour; //shape's colour
        protected int x, y; //not I could use c# properties for this
        public Shape(Color colour, int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            //can't provide anything else as "shape" is too general
        }

        public virtual void draw(Graphics g)
        {
            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip;
            String text = this.ToString();
            g.DrawString(text, drawFont, drawBrush, this.x, this.y, drawFormat);
        }

        public virtual float calcArea()
        {
            return 0; //a shape has no area
        }

        public override string ToString() //get the standard object name and break hierarchy to get just the name
        {
            String text = base.ToString();
            String[] sut = text.Split('.');
            text = sut[sut.Length - 1];
            return text;
        }

    }
}
