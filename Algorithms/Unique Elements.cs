//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Unique_Elements
//    {
//        public static void Main()
//        {
//            new Unique_Elements().Run(Console.In, Console.Out);
//        }

//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[] elements = { 1, 2, 3, 4, 5, 6, 7, 78, 8, 9, 0, 2, 90, 38, 4980 };
//            var result = UniqueElements(elements);
//            writer.Write(result);
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Determines whether all the elemnts in a given array are distinct
//        /// </summary>
//        /// <param name="A">An array A[0..n-1]</param>
//        /// <returns>True if all the elements in A are distinct and False otherwise</returns>
//        public bool UniqueElements(int[] A)
//        {
//            for (int i = 0; i < A.Length - 2; i++)
//            {
//                for (int j = i + 1; j < A.Length - 1; j++)
//                    if (A[i] == A[j]) return false;
//            }
//            return true;
//        }
//    }
//}
