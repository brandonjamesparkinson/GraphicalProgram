// ***********************************************************************
// Assembly         : GraphicalProgram
// Author           : Brandon
// Created          : 01-05-2019
//
// Last Modified By : Brandon
// Last Modified On : 01-06-2019
// ***********************************************************************
// <copyright file="Square.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace GraphicalProgram
{

    //class for square shape 
    //square calls from rectangle as that is its parent class 
    /// <summary>
    /// Class Square.
    /// Implements the <see cref="GraphicalProgram.Rectangle" />
    /// </summary>
    /// <seealso cref="GraphicalProgram.Rectangle" />
    class Square : Rectangle
    {

        //variable for size 
        /// <summary>
        /// The size
        /// </summary>
        private int size;

        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        public Square() : base()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Square"/> class.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <param name="size">The size.</param>
        public Square(Color colour, int x, int y, int size) : base(x, y, size, size)
        {
            this.size = size;
        }

        //no draw method here because it is provided by the parent class Rectangle
        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public override void draw(Graphics g)
        {
            base.draw(g);
        }

    }
}
