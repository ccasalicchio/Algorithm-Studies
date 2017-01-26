//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Max_Element
//    {
//        public static void Main()
//        {
//            new Max_Element().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[] array = { 12, 43, 5543, 654, 23, 67, 885, 34, 654, 25, 67 };
//            writer.WriteLine(MaxElement(array));
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Determines the value of the largest element in a given array
//        /// </summary>
//        /// <param name="A">An array A[0..n-1] of real numbers</param>
//        /// <returns>The value of the largest element in A</returns>
//        public int MaxElement(int[] A)
//        {
//            int maxval = A[0];
//            for (int i = 1; i < A.Length; i++)
//            {
//                if (A[i] > maxval) maxval = A[i];
//            }
//            return maxval;
//        }
//    }
//}
