using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a single-dimensional array of 5 integers.
            string[] array1 = new string[5];

            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            // Alternative syntax.
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            // Declare a two dimensional array.
            int[,] multiDimensionalArray1 = new int[2, 3];

            // Declare and set array element values.
            int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Declare a jagged array.
            int[][] jaggedArray = new int[6][];

            // Set the values of the first array in the jagged array structure.
            jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

            Console.WriteLine( array3[0] );
            array3[0] = 10;
            Console.WriteLine( array3[0] );

            array1[0] = "First";
            array1[1] = "Second";
            Console.WriteLine( array1[2] );
            // Array methods
            Console.WriteLine( "Length is {0}.", array1.Length );
            Console.WriteLine("Rank is {0} for 2-d array.", multiDimensionalArray1.Rank);
            Console.WriteLine("Rank is {0} for jagged array.", jaggedArray.Rank);

        }
    }
}