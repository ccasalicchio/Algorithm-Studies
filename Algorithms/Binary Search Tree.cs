//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    /// <summary>
//    /// page 297
//    /// </summary>
//    public class Binary_Search_Tree
//    {
//        public static void Main()
//        {
//            new Binary_Search_Tree().Run(Console.In, Console.Out);
//        }
//        void Run(TextReader reader, TextWriter writer)
//        {
//            writer.Write(OptimalBST(new int[] { 1, 3, 4, 6, 5, 7, 8, 9, 10 }));
//            reader.Read();
//        }
//        /// <summary>
//        /// Finds an optimal binary search tree by dynamic programming
//        /// </summary>
//        /// <param name="P">An array P[1..n] of search probabilities for a sorted list of n keys</param>
//        /// <returns>Average number of comparisons in successful seraches in the optimal BST and table R of subtress roots in the Optimal BST</returns>
//        Tuple<int, int[,]> OptimalBST(int[] P)
//        {
//            int[,] C = new int[P.Length, P.Length];
//            int[,] R = new int[P.Length, P.Length];
//            for (int i = 1; i < P.Length; i++)
//            {
//                C[i, i - 1] = 0;
//                C[i, i] = P[i];
//                R[i, i] = i;
//            }
//            C[P.Length + 1, P.Length] = 0;
//            for (int d = 0; d < P.Length - 1; d++)//diagonal count
//            {
//                for (int i = 1; i < P.Length - d; i++)
//                {
//                    int j = i + d;
//                    int minval = int.MaxValue;
//                    for (int k = i; k <= j; k++)
//                    {
//                        int kmin = 0;
//                        if (C[i, k - 1] + C[k + 1, j] < minval)
//                        {
//                            minval = C[i, k - 1] + C[k + 1, j];
//                            kmin = k;
//                        }
//                        R[i, j] = kmin;
//                        int sum = P[i];
//                        for (int s = i + 1; s <= j; s++)
//                        {
//                            sum = sum + P[s];
//                        }
//                        C[i, j] = minval + sum;
//                    }
//                }
//            }
//            return Tuple.Create(C[1, P.Length], R);
//        }
//    }
//}
