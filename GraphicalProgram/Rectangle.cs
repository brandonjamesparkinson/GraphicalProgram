// ***********************************************************************
// Assembly         : GraphicalProgram
// Author           : Brandon
// Created          : 01-05-2019
//
// Last Modified By : Brandon
// Last Modified On : 01-06-2019
// ***********************************************************************
// <copyright file="Rectangle.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace GraphicalProgram
{

    //class for rectangle shape 
    //parent class for rectangle is Shape 
    //rectangle is the parent class for square 
    /// <summary>
    /// Class Rectangle.
    /// Implements the <see cref="GraphicalProgram.Shape" />
    /// </summary>
    /// <seealso cref="GraphicalProgram.Shape" />
    class Rectangle : Shape
    {
        //all rectangles need width and height 
        /// <summary>
        /// The width
        /// </summary>
        int width, height;
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        public Rectangle() : base()
        {
            width = 100;
            height = 100;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Rectangle"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {

            this.width = width; //the only thing that is different from shape
            this.height = height;
        }

        /// <summary>
        /// Sets the specified colour.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <param name="list">The list.</param>
        public override void set(Color colour, params int[] list)
        {
            //list[0] is x, list[1] is y, list[2] is width, list[3] is height
            base.set(colour, list[0], list[1]);
            this.width = list[2];
            this.height = list[3];

        }

        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public override void draw(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            SolidBrush b = new SolidBrush(colour);
            g.FillRectangle(b, x, y, width, height);
            g.DrawRectangle(p, x, y, width, height);
        }

        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>System.Double.</returns>
        public override double calcArea()
        {
            return width * height;
        }

        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>System.Double.</returns>
        public override double calcPerimeter()
        {
            return 2 * width + 2 * height;
        }
    }
}
