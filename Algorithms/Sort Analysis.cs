//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    /// <summary>
//    /// page 90
//    /// </summary>
//    public class Sort_Analysis
//    {
//        public static void Main()
//        {
//            new Sort_Analysis().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            writer.WriteLine(SortAnalysis(new int[] { 9, 2, 8, 3, 4 }));
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Counts how many sorts it took to order the array
//        /// </summary>
//        /// <param name="A">An array A[0..n-1] of n orderable elements</param>
//        /// <returns>The total number of key comparisons made</returns>
//        public int SortAnalysis(int[] A)
//        {
//            int count = 0;
//            for (int i = 1; i < A.Length; i++)
//            {
//                int v = A[i];
//                int j = i - 1;
//                while (j >= 0 && A[j] > v)
//                {
//                    count++;
//                    A[j + 1] = A[j];
//                    j--;
//                }
//                A[j + 1] = v;
//            }
//            return count;
//        }
//    }
//}
