using System;
using System.Drawing;

namespace GraphicalProgram
{

    //class for the circle shape
    //the parent class for circle is shape 
    class Circle : Shape
    {
        int radius;

        public Circle() : base()
        {

        }
        public Circle( int x, int y, int radius) : base(x, y)
        {

            this.radius = radius; //the only thing that is different from shape
        }


        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            base.set(colour, list[0], list[1]);
            this.radius = list[2];


        }



        public override void draw(Graphics g)
        {

            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

        }

        public override double calcArea()
        {
            return Math.PI * (radius ^ 2);
        }

        public override double calcPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}
