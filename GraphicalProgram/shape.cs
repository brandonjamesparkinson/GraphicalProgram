// ***********************************************************************
// Assembly         : GraphicalProgram
// Author           : Brandon
// Created          : 01-05-2019
//
// Last Modified By : Brandon
// Last Modified On : 01-10-2019
// ***********************************************************************
// <copyright file="shape.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace GraphicalProgram
{

    //class for the shape 
    //parent class for shape is Shapes
    /// <summary>
    /// Class Shape.
    /// Implements the <see cref="GraphicalProgram.Shapes" />
    /// </summary>
    /// <seealso cref="GraphicalProgram.Shapes" />
    public abstract class Shape : Shapes
    {
        /// <summary>
        /// The colour
        /// </summary>
        protected Color colour; //shape's colour
        /// <summary>
        /// The x
        /// </summary>
        protected int x, y; //always have an X and Y 
        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        public Shape() //Shape can be accessed by any other class
        {
            x = y = 100;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Shape"/> class.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public Shape( int x, int y)
        {

            this.colour = colour; //shape's colour
            this.x = x; //its x pos
            this.y = y; //its y pos
            //can't provide anything else as "shape" is too general
        }

        //the three methods below are from the Shapes interface
        //here we are passing on the obligation to implement them to the derived classes by declaring them as abstract
        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        public abstract void draw(Graphics g); //any derrived class must implement this method
        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>System.Double.</returns>
        public abstract double calcArea();
        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>System.Double.</returns>
        public abstract double calcPerimeter();

        //set is declared as virtual so it can be overridden by a more specific child version
        //but is here so it can be called by that child version to do the generic stuff
        //note the use of the param keyword to provide a variable parameter list to cope with some shapes having more setup information than others
        /// <summary>
        /// Sets the specified colour.
        /// </summary>
        /// <param name="colour">The colour.</param>
        /// <param name="list">The list.</param>
        public virtual void set(Color colour, params int[] list)
        {
            this.colour = colour;
            this.x = list[0];
            this.y = list[1];
        }


        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return base.ToString() + "    " + this.x + "," + this.y + " : ";
        }

    }
}
