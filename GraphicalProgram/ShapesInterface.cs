// ***********************************************************************
// Assembly         : GraphicalProgram
// Author           : Brandon
// Created          : 01-05-2019
//
// Last Modified By : Brandon
// Last Modified On : 01-05-2019
// ***********************************************************************
// <copyright file="ShapesInterface.cs" company="">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Drawing;

namespace GraphicalProgram
{

    /*
    //creates an interface for the shapes used in the program 
    //each shape used with have parameters. each shape will be drawn and will have both area and perimeter
    each interface can only contain signatures of methods, properties, events, or indexers without implementations 
    */
    /// <summary>
    /// Interface Shapes
    /// </summary>
    interface Shapes
    {
        /// <summary>
        /// Sets the specified c.
        /// </summary>
        /// <param name="c">The c.</param>
        /// <param name="list">The list.</param>
        void set(Color c, params int[] list);
        /// <summary>
        /// Draws the specified g.
        /// </summary>
        /// <param name="g">The g.</param>
        void draw(Graphics g);
        /// <summary>
        /// Calculates the area.
        /// </summary>
        /// <returns>System.Double.</returns>
        double calcArea();
        /// <summary>
        /// Calculates the perimeter.
        /// </summary>
        /// <returns>System.Double.</returns>
        double calcPerimeter();

    }
}
