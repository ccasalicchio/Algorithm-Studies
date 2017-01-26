//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Fibonacci
//    {
//        public static void Main()
//        {
//            new Fibonacci().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            writer.Write(F(6));
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Computes the nth Fibonatti number recursively by using its definition
//        /// </summary>
//        /// <param name="n">A nonnegative integer n</param>
//        /// <returns>The nth Fibonacci number</returns>
//        public int F(int n)
//        {
//            if (n <= 1) return n;
//            else return F(n - 1) + F(n - 2);
//        }
//    }
//}
