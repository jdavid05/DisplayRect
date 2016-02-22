/* Purpose: Display a rectangle of asterisks
 * Author : Joseph Davidson
 * Date   : February, 2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayRect
{
    class ProcessRect
    {
        #region Fields
        /// <summary>
        /// Fields
        /// </summary>
        private string coordinateXInput, coordinateYInput, widthInput    , heightInput    ;
        private int    coordinateX     , coordinateY     , rectangleWidth, rectangleHeight;
        #endregion

        #region Properties
        /// <summary>
        /// Properties
        /// </summary>
        public int CoordinateX { get { return coordinateX;     } set { coordinateX = value;     } }
        public int CoordinateY { get { return coordinateY;     } set { coordinateY = value;     } }
        public int Width       { get { return rectangleWidth;  } set { rectangleWidth  = value; } }
        public int Height      { get { return rectangleHeight; } set { rectangleHeight = value; } }
        #endregion

        #region Initial Constructor
        /// <summary>
        /// Initial Constructor -- all values specified.
        /// </summary>
        /// <param name="px">Point X</param>
        /// <param name="py">Point Y</param>
        /// <param name="wh">Width</param>
        /// <param name="ht">Height</param>
        public ProcessRect(int px, int py, int wh, int ht)
        {
            CoordinateY = py;
            CoordinateX = px;
            Width       = wh;
            Height      = ht;
        }
        #endregion

        #region Empty Constructor
        /// <summary>
        /// Empty constructor -- No values specified.
        /// </summary>
        public ProcessRect() : this(0, 0, 0, 0) { }
        #endregion

        #region Method - Display the rectangle
        /// <summary>
        /// Display the rectangle.
        /// </summary>
        public void DisplayRectDim()
        {
            // For every value in the sum of Coordinate Y:
            for (int i = 0; i < CoordinateY; i++)
            {
                // Write an empty line.
                Console.WriteLine();
            }
            // For every value in the height of the rectangle:
            for (int j = 0; j < Height; j++)
            {
                // For every value in the sum of Coordinate X:
                for (int k = 0; k < CoordinateX; k++)
                {
                    // Move the line over by one space.
                    Console.Write(" ");
                }
                // For the width of the rectangle:
                for (int l = 0; l < Width; l++)
                {
                    // Write an asterisk.
                    Console.Write("*");
                }
                // Start a new line.
                Console.WriteLine();
            }
            // Write an empty line.
            Console.WriteLine();
        }
        #endregion

        #region Public Method - Rectangle dimensions
        /// <summary>
        /// Ask the user to input the rectangle's dimensions.
        /// </summary>
        public void GetRectDim()
        {
            Console.Write("Enter the value for X      : ");
            coordinateXInput = Console.ReadLine();

            Console.Write("Enter the value for Y      : ");
            coordinateYInput = Console.ReadLine();

            Console.Write("Enter the value for width  : ");
            widthInput = Console.ReadLine();

            Console.Write("Enter the value for height : ");
            heightInput = Console.ReadLine();

            this.CalcRectDim();
        }
        #endregion

        #region Public Method - Keep Going
        /// <summary>
        /// Ask the user if they want to continue.
        /// </summary>
        /// <returns>The boolean continue value.</returns>
        public bool KeepGoing()
        {
            String sIn;
            Console.Write("Do you want to continue (Y/N)? ");
            sIn = Console.ReadLine();
            // If the user enters 'Y' or 'y':
            if ((sIn == "Y") || (sIn == "y"))
            {
                // Print an empty line and set boolean continue to true.
                Console.WriteLine();
                return true;
            }
            // If the user does not enter 'Y' or 'y':
            else
            {
                // Set boolean continue to false.
                return false;
            }
        }
        #endregion

        #region Private Method - Calculate Rectangle Dimensions
        /// <summary>
        /// Convert the X, Y, width and height strings to integers.
        /// </summary>
        private void CalcRectDim()
        {
            // Can't set properties.
            // Error: A property, indexer, or dynamic member access may 
            //      not be passed as an out or ref parameter.
            int.TryParse(widthInput,  out rectangleWidth );
            int.TryParse(heightInput, out rectangleHeight);
            int.TryParse(coordinateXInput, out coordinateX         );
            int.TryParse(coordinateYInput, out coordinateY         );
            return;
        }
        #endregion
    }
}
