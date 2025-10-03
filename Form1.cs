using ShapesInheritanceExample;
using System.Collections;

namespace InheritanceExample
{
    public partial class Form1 : Form
    {

        ArrayList shapes = new ArrayList();
       
        public Form1()
        {
            InitializeComponent();

            //add a few shapes
            shapes.Add(new Circle(Color.Purple, 10, 100, 100)); //create a red circle at (10,100) of radius 100
            shapes.Add(new Circle(Color.Chartreuse, 100, 10, 50)); //apparently it's green
            shapes.Add(new Circle(Color.Red, 10, 100, 100));
            shapes.Add(new Rect(Color.Blue, 150, 150, 50, 100));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("paint called");
            Graphics g = e.Graphics;


            for (int i = 0; i < shapes.Count; i++)
            {
                Shape s;

                s = (Shape)shapes[i];
                s.draw(g);
                Console.WriteLine(s.ToString());

            }
           
        }
    }
}
