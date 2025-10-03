using ShapesInheritanceExample;
using System.Collections;

namespace InheritanceExample
{
    public partial class Form1 : Form
    {

        ArrayList circles = new ArrayList();
        ArrayList rectangles = new ArrayList();
        public Form1()
        {
            InitializeComponent();

            //add a few shapes
            circles.Add(new Circle(Color.Purple, 10, 100, 100)); //create a red circle at (10,100) of radius 100
            circles.Add(new Circle(Color.Chartreuse, 100, 10, 50)); //apparently it's green
            rectangles.Add(new Rect(Color.Blue, 150, 150, 50, 100));
            circles.Add(new Circle(Color.Red, 10, 100, 100));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("paint called");
            Graphics g = e.Graphics;


            for (int i = 0; i < circles.Count; i++)
            {
                Circle c;
                
                c = (Circle) circles[i];
                c.draw(g);
                Console.WriteLine(c.Description());

            }
            for (int i = 0; i < rectangles.Count; i++)
            {
                Rect r;

                r = (Rect) rectangles[i];
                r.draw(g);
                Console.WriteLine(r.Description());

            }
        }
    }
}
