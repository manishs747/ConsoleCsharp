using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManishConsoleApp.collection
{


    /**
     * A jagged array is an array whose elements are arrays, possibly of different sizes. 
     * A jagged array is sometimes called an "array of arrays
     * */
    public class JaggedArray
    {
        public static void Main()
        {
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            int[][] jaggedArray2 = new int[][]
                                {
                                new int[] { 1, 3, 5, 7, 9 },
                                new int[] { 0, 2, 4, 6 },
                                new int[] { 11, 22 }
                                };
        }

        int[][] jaggedArray3 =
                    {
                            new int[] { 1, 3, 5, 7, 9 },
                            new int[] { 0, 2, 4, 6 },
                            new int[] { 11, 22 }
                        };
    }




}
