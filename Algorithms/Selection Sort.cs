//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    /// <summary>
//    /// page 99
//    /// </summary>
//    public class Selection_Sort
//    {
//        public static void Main()
//        {
//            new Selection_Sort().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[] result = SelectionSort(new int[] { 89, 45, 68, 90, 29, 34, 17 });
//            foreach (int i in result) writer.Write(i + ",");
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Sorts a given array by selection sort
//        /// </summary>
//        /// <param name="A">an array A[0..n-1] or orderable elements</param>
//        /// <returns>Array A[0..n-1] sorted in ascending order</returns>
//        public int[] SelectionSort(int[] A)
//        {
//            for (int i = 0; i <= A.Length - 2; i++)
//            {
//                int min = i;
//                for (int j = i + 1; j <= A.Length - 1; j++)
//                {
//                    if (A[j] < A[min]) min = j;
//                    Swap(ref A, i, min);
//                }
//            }
//            return A;
//        }
//        void Swap(ref int[] A, int index, int min)
//        {
//            int a = A[index], b = A[min];
//            A[index] = b;
//            A[min] = a;
//        }
//    }
//}
