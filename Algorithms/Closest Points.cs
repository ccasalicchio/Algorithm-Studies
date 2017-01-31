//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    /// <summary>
//    /// page 108
//    /// </summary>
//    public class Closest_Points
//    {
//        public static void Main()
//        {
//            new Closest_Points().Run(Console.In, Console.Out);

//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            writer.WriteLine(BruteForceClosestPoints(new int[,] { { 3, 5 }, { 6, 7 }, { 1, 5 }, { 4, 9 } }));
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Finds two closest points in the plane by brute force
//        /// </summary>
//        /// <param name="P">A list P of n(n>=2) points P1 = (x1,y2)...,Pn=(xn,yn)</param>
//        /// <returns>Indices index 1 and index 2 of the closese pair of points</returns>
//        public Tuple<int, int> BruteForceClosestPoints(int[,] P)
//        {
//            double dmin = int.MaxValue;
//            int index1 = 0, index2 = 0;
//            int length = P.GetLength(0);
//            for (int i = 1; i < length - 1; i++)
//            {
//                for (int j = i + 1; j < length; j++)
//                {
//                    double d = Math.Sqrt((P[i, 0] - P[j, 0]) + (P[i, 1] - P[j, 1]));
//                    if (d < dmin)
//                    {
//                        dmin = d;
//                        index1 = i;
//                        index2 = j;
//                    }
//                }
//            }
//            return Tuple.Create(index1, index2);
//        }
//    }
//}
