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
    class Program
    {
        static void Main(string[] args)
        {
            // Test the initial constructor -- All parameters specified.
            Console.WriteLine("Test the initial constructor -- x = 10, y = 3, width = 20, height = 5");
            ProcessRect ProcessRectangle1 = new ProcessRect(10, 3, 20, 5);
            ProcessRectangle1.DisplayRectDim();

            // Test the empty constructor -- No parameters specified (Default to zero).
            Console.WriteLine("Test the second constructor -- no values specified");
            ProcessRect ProcessRectangle2 = new ProcessRect();
            ProcessRectangle2.DisplayRectDim();

            // Test user input -- User specifies parameters.
            ProcessRect ProcessRectangle = new ProcessRect();

            // Set the boolean continue value to true.
            bool bContinue = true;
            // While boolean continue is true:
            while (bContinue)
            {
                // Get the user input for x, y, width, and height and display the rectangle.
                ProcessRectangle.GetRectDim();
                ProcessRectangle.DisplayRectDim();
                // Ask the user if they would like to continue -- set the boolean continue value.
                bContinue = ProcessRectangle.KeepGoing();
            }

            // While boolean continue is false allow the user to exit the program.
            Console.Write("Press ENTER to exit");
            Console.ReadLine();
        }
    }
}
