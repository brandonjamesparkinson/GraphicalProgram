using System.Drawing;

namespace GraphicalProgram
{

    /*
    //creates an interface for the shapes used in the program 
    //each shape used with have parameters. each shape will be drawn and will have both area and perimeter
    each interface can only contain signatures of methods, properties, events, or indexers without implementations 
    */
    interface Shapes
    {
        void set(Color c, params int[] list);
        void draw(Graphics g);
        double calcArea();
        double calcPerimeter();

    }
}
