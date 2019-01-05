using System.Drawing;

namespace GraphicalProgram
{
    class Square : Rectangle
    {
        private int size;

        public Square() : base()
        {

        }
        public Square(Color colour, int x, int y, int size) : base(x, y, size, size)
        {
            this.size = size;
        }

        //no draw method here because it is provided by the parent class Rectangle
        public override void draw(Graphics g)
        {
            base.draw(g);
        }

    }
}
