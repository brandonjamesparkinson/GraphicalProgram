using System;

namespace GraphicalProgram
{

    //class for Shape Factory
    //following the factory design pattern 
    //a factory creates objects. this is implemented in c# programs. 
    class ShapeFactory
    {
        public Shape getShape(String shapeType)
        {
            shapeType = shapeType.ToUpper().Trim(); //you could argue that you want a specific word string to create an object but I'm allowing any case combination


            if (shapeType.Equals("CIRCLE"))
            {
                return new Circle();

            }
            else if (shapeType.Equals("RECTANGLE"))
            {
                return new Rectangle();

            }
            else if (shapeType.Equals("SQUARE"))
            {
                return new Square();
            }

            else if (shapeType.Equals("TRIANGLE"))
            {
                return new Square();
            }

            else if (shapeType.Equals("POLYGON"))
            {
                return new Square();
            }
            else
            {

                //If this is reached then what has been passed is not recognised. A user friendly exception was thrown.
                System.ArgumentException argEx = new System.ArgumentException("Shape Factory error: " + shapeType + " does not exist");
                throw argEx;
            }
        }
    }
}
