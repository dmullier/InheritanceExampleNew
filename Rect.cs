using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ShapesInheritanceExample
{
    public class Rect
    {
        protected int width, height;
        protected Color colour;
        protected int x, y; //not I could use c# properties for this
        public Rect(Color colour, int x, int y, int width, int height)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            this.width = width; 
            this.height = height;
        }

        public void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, x, y, width, height);
            g.DrawRectangle(p, x, y, width, height);

            Font drawFont = new Font("Arial", 12);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.NoClip;
            String text = this.Description();
            g.DrawString(text, drawFont, drawBrush, this.x, this.y, drawFormat);
        }

        public string Description() //get the standard object name and break hierarchy to get just the name
        {
            String text = this.ToString();
            String[] sut = text.Split('.');
            text = sut[sut.Length - 1];
            return text;
        }

    }
}