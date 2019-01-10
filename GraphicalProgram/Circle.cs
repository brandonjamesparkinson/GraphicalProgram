// ***********************************************************************
// Assembly         : GraphicalProgram
// Author           : Brandon
// Created          : 01-05-2019
//
// Last Modified By : Brandon
// Last Modified On : 01-06-2019
// ***********************************************************************
// <copyright file="Circle.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Drawing;

namespace GraphicalProgram
{

    //class for the circle shape
    //the parent class for circle is shape 
    /// <summary>
    /// Class Circle.
    /// Implements the <see cref="GraphicalProgram.Shape" />
    /// </summary>
    /// <seealso cref="GraphicalProgram.Shape" />
    class Circle : Shape
    {
        /// <summary>
        /// The radius
        /// </summary>
        int radius;

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        public Circle() : base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="radius">The radius.</param>
        public Circle( int x, int y, int radius) : base(x, y)
        {

            this.radius = radius; //the only thing that is different from shape
        }

        /// <summary>
        /// Sets the specified colour.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <param name="list">The list.</param>
        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is radius
            base.set(colour, list[0], list[1]);
            this.radius = list[2];
        }

        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public override void draw(Graphics g)
        {

            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.DrawEllipse(p, x, y, radius * 2, radius * 2);

        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>System.Double.</returns>
        public override double calcArea()
        {
            return Math.PI * (radius ^ 2);
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>System.Double.</returns>
        public override double calcPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString() //all classes inherit from object and ToString() is abstract in object
        {
            return base.ToString() + "  " + this.radius;
        }
    }
}
