//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Pseudo_Random
//    {
//        public static void Main()
//        {
//            new Pseudo_Random().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int result = Mistery(12);

//            writer.Write(result);
//            reader.ReadLine();
//        }
//        public int Mistery(int n)
//        {
//            int S = 0;
//            for (int i = 0; i < n; i++)
//            {
//                S = S + i * i;
//            }
//            return S;
//        }
//    }
//}
