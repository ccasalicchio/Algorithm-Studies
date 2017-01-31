//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Pseudo_Random_2
//    {
//        public static void Main()
//        {
//            new Pseudo_Random_2().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            foreach (var r in Random(12, 8, 12, 6, 3))
//            {
//                writer.WriteLine(r);
//            }
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Generates a sequence of n pseudorandomg numbers according to the linear congruential method
//        /// </summary>
//        /// <param name="n">A positive integer</param>
//        /// <param name="m">A positive integer</param>
//        /// <param name="seed">A positive integer</param>
//        /// <param name="a">A positive integer</param>
//        /// <param name="b">A positive integer</param>
//        /// <returns>A sequence r1...,rn of n pseudorandom integers uniformly distributed among integer values between 0 and m-1</returns>
//        /// <remarks>Note: Pseudorandom numbers between 0 and 1 can be obtained by treating the integers generated as digits after the decimal point</remarks>
//        public int[] Random(int n, int m, int seed, int a, int b)
//        {
//            int[] r = new int[n];
//            r[0] = seed;
//            for (int i = 1; i < n ; i++)
//                r[i] = (a * r[i - 1] + b) % m;

//            return r;
//        }
//    }
//}
