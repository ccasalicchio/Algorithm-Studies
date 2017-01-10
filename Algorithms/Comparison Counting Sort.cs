//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Comparison_Counting_Sort
//    {
//        public static void Main()
//        {
//            new Comparison_Counting_Sort().Run(Console.In, Console.Out);
//        }

//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[] array = Setup();

//            var results = ComparisonCountingSort(array);
//            foreach (var result in results)
//                writer.Write(result + ",");

//            Console.ReadLine();

//        }

//        public int[] Setup()
//        {
//            return new int[] { 23, 43, 293, 493, 22, 233, 12, 1, 42, 56, 9, 84, 92, 32, 54, 67 };
//        }
//        /// <summary>
//        /// Sorts an array by comparison couting
//        /// </summary>
//        /// <param name="A">Array A[0..n-1] of orderable values</param>
//        /// <returns>Array S[0..n-1] of A's elemements sorted in nondecreasing order</returns>
//        public Array ComparisonCountingSort(int[] A)
//        {
//            int[] count = new int[A.Length];
//            int[] S = new int[A.Length];

//            for (int i = 0; i < A.Length - 1; i++)
//                count[i] = 0;

//            for (int i = 0; i < A.Length - 2; i++)
//            {
//                for (int j = i + 1; j < A.Length - 1; j++)
//                {
//                    if (A[i] < A[j])
//                        count[j]++;
//                    else count[i]++;

//                }
//            }
//            for (int i = 0; i < A.Length - 1; i++)
//                S[count[i]] = A[i];

//            return S;
//        }
//    }
//}
