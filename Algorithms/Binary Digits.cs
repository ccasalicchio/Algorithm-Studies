//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Binary_Digits
//    {
//        public static void Main()
//        {
//            new Binary_Digits().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            writer.Write(BinRec(75));
//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Recursive  representation of n's binary
//        /// </summary>
//        /// <param name="n">A positive decimal integer n</param>
//        /// <returns>The number of binary digits in n's binary representation</returns>
//        public decimal BinRec(decimal n)
//        {
//            if (n == 1) return 1;
//            else return BinRec(Math.Floor(n / 2)) + 1;
//        }
//    }
//}
