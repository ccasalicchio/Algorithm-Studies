//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Secret_and_Enigma
//    {
//        public static void Main()
//        {
//            new Secret_and_Enigma().Run(Console.In, Console.Out);
//        }

//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[] secret = { 0, 2, 6, 7, 5, 8, 99, 44, 55, 66, 77 };
//            int[,] enigma = { { 2, 3, 4, 5 }, { 3, 4, 6, 8 }, { 4, 33, 44, 55 }, { 12, 23, 44, 56 } };

//            writer.WriteLine("Secret");
//            writer.WriteLine(Secret(secret));

//            writer.WriteLine("Enigma");
//            writer.WriteLine(Enigma(enigma));

//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Discovers the subtraction of the highest element from the lowest element in array A
//        /// </summary>
//        /// <param name="A">Array of integers</param>
//        /// <returns>The subtraction from the highest element from the lowest element</returns>
//        public int Secret(int[] A)
//        {
//            int minval = A[0];
//            int maxval = A[0];
//            for (int i = 0; i < A.Length; i++)
//            {
//                if (A[i] < minval) minval = A[i];
//                if (A[i] > maxval) maxval = A[i];
//            }
//            return maxval - minval;
//        }
//        /// <summary>
//        /// Discovers if the multidimensional array is all the same values
//        /// </summary>
//        /// <param name="A">A matrix A[0..n-1],[0..n-1])</param>
//        /// <returns>wheter the array is an enigma</returns>
//        public bool Enigma(int[,] A)
//        {
//            for (int i = 0; i < A.Length - 1; i++)
//            {
//                for (int j = i + 1; j < A.Length; j++)
//                {
//                    if (A[i, j] != A[j, i]) return false;
//                }
//            }
//            return true;
//        }
//    }
//}
