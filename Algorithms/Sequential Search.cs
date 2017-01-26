//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Sequential_Search
//    {
//        public static void Main()
//        {
//            new Sequential_Search().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[] array = { 12, 43, 589, 323, 45, 23, 99, 238, 344, 596, 3482, 2039 };
//            int key = 596;

//            var result = SequentialSearch(array, key);

//            writer.WriteLine(result);
//            reader.ReadLine();
//        }
//        public Sequential_Search()
//        {

//        }
//        /// <summary>
//        /// Searches for a given value in a given array by sequential search
//        /// </summary>
//        /// <param name="A">An array A[0..n-1]</param>
//        /// <param name="K">search key K</param>
//        /// <returns>The index of the first element of A that matches K or -1 if there are no matching elements</returns>
//        public int SequentialSearch(int[] A, int K)
//        {
//            int i = 0;
//            while (i < A.Length && A[i] != K)
//                i++;

//            if (i < A.Length) return i;
//            else return -1;
//        }
//    }
//}
