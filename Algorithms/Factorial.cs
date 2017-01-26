//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Factorial
//    {
//        public static void Main()
//        {
//            new Factorial().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            writer.Write(F(15));
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Computes n! recursively
//        /// </summary>
//        /// <param name="n">A nonnegative integer n</param>
//        /// <returns>The value of n!</returns>
//        public int F(int n)
//        {
//            if (n == 0) return 1;
//            else return F(n - 1) * n;
//        }
//    }
//}
