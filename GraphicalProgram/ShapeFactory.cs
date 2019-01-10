// ***********************************************************************
// Assembly         : GraphicalProgram
// Author           : Brandon
// Created          : 01-05-2019
//
// Last Modified By : Brandon
// Last Modified On : 01-06-2019
// ***********************************************************************
// <copyright file="ShapeFactory.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;

namespace GraphicalProgram
{

    //class for Shape Factory
    //following the factory design pattern 
    //a factory creates objects. this is implemented in c# programs. 
    /// <summary>
    /// Class ShapeFactory.
    /// </summary>
    class ShapeFactory
    {
        /// <summary>
        /// Gets the shape.
        /// </summary>
        /// <param name="shapeType">Type of the shape.</param>
        /// <returns>Shape.</returns>
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
