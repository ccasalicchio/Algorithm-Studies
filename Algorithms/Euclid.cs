//using System;
//using System.IO;

//namespace Algorithms
//{
//    public class Euclid
//    {
//        public static void Main()
//        {
//            new Euclid().Run(Console.In, Console.Out);
//        }

//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int m = int.Parse(reader.ReadLine());
//            int n = int.Parse(reader.ReadLine());

//            var results = GCD(m, n);
//            writer.Write(results);

//            Console.ReadLine();

//        }
//        /// <summary>
//        /// Computes Greates Common Divisor by Euclids Algorithm
//        /// Input: Two nonnegative, not-both-zero integers m and n
//        /// Output: Greatest common divisor of m and n
//        /// </summary>
//        /// <param name="m">First Number</param>
//        /// <param name="n">Second Number</param>
//        /// <returns>Greatest Common Divisor or m and n</returns>
//        public int GCD(int m, int n)
//        {
//            while (n != 0)
//            {
//                int r = m % n;
//                m = n;
//                n = r;
//            }
//            return m;
//        }
//    }
//}
