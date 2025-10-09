using ShapesInheritanceExample;
using System.Collections;
using System.Diagnostics;

namespace InheritanceExample
{
    public partial class Form1 : Form
    {

        List<Shape> shapes = new List<Shape>();
        Bitmap myBitmap;


        public Form1()
        {
            InitializeComponent();
            myBitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);

            //add a few shapes

            Random rand = new Random(77887);
            for (int i = 0; i < 150; i++)
            {
                int x = rand.Next(Size.Width);
                int y = rand.Next(Size.Height);
                int size = rand.Next(250);

                int red = rand.Next(255);
                int green = rand.Next(255);
                int blue = rand.Next(255);

                Color newColour = Color.FromArgb(128, red, green, blue); //128 is semi transparent

                int shape = rand.Next(4);

                switch (shape)
                {
                    case 0:
                        shapes.Add(new Circle(newColour, x, y, size));
                        break;
                    case 1:
                        shapes.Add(new Square(newColour, x, y, size));
                        break;
                    case 2:
                        shapes.Add(new Rect(newColour, x, y, size, size / 2));
                        break;
                    case 3: 
                        shapes.Add(new Triangle(newColour, x, y, size));
                        break;


                }
            }

            Graphics g = Graphics.FromImage(myBitmap);
            for (int i = 0; i < shapes.Count; i++)
            {
                Shape s;

                s = (Shape)shapes[i];
                s.draw(g);
                Debug.WriteLine(s.ToString() + " area is " + s.calcArea());

            }

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("paint called");
            Graphics g = e.Graphics;
            g.DrawImage(myBitmap, 0, 0);


        }
           
        
    }
}
