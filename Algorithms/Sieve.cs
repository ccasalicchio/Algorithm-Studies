//using System;
//using System.IO;

//namespace Algorithms
//{

//    public class Erathostenes
//    {
//        public static void Main()
//        {
//            new Erathostenes().Run(Console.In, Console.Out);
//        }

//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int n = int.Parse(reader.ReadLine());
//            var results = Sieve(n);

//            foreach (int result in results)
//            {
//                if (result > 0)
//                    writer.Write(result + "\t");
//            }

//            Console.ReadLine();

//        }
//        /// <summary>
//        /// Implementes the sieve of Eratosthenes
//        /// Input: An integrer n>=2
//        /// Output: Array L of all prime numbers less than or equal to n
//        /// </summary>
//        public Array Sieve(int n)
//        {
//            int[] A = new int[n + 2];
//            for (int p = 2; p <= n; p++)
//                A[p] = p;

//            for (int p = 2; p <= Math.Floor(Math.Sqrt(n)); p++)
//            {
//                if (A[p] != 0)
//                {
//                    int j = p * p;
//                    while (j <= n)
//                    {
//                        A[j] = 0;
//                        j = j + p;
//                    }
//                }
//            }
//            int i = 0;
//            int[] L = new int[A.Length];
//            for (int p = 2; p <= n; p++)
//            {
//                if (A[p] != 0)
//                {
//                    L[i] = A[p];
//                    i++;
//                }
//            }
//            return L;
//        }
//    }
//}
