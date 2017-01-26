//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    public class Matrix_Multiplication
//    {
//        public static void Main()
//        {
//            new Matrix_Multiplication().Run(Console.In, Console.Out);
//        }
//        public void Run(TextReader reader, TextWriter writer)
//        {
//            int[,] A = { { 3, 5 }, { 2, 7 } };
//            int[,] B = { { 1, 4 }, { 8, 7 } };
//            float[,] C = MatrixMultiplication(A, B);

//            foreach (int i in C) writer.Write("{0},", i);

//            reader.ReadLine();
//        }
//        /// <summary>
//        /// Multiplies two n-by-n matrices by the definition-based algorith
//        /// </summary>
//        /// <param name="A">Matrix A</param>
//        /// <param name="B">Matrix B</param>
//        /// <returns>Matrix C = AB</returns>
//        public float[,] MatrixMultiplication(int[,] A, int[,] B)
//        {
//            int size = A.Length / 2;
//            float[,] C = new float[size, size];
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    C[i, j] = 0.0f;
//                    for (int k = 0; k < size; k++)
//                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
//                }
//            }
//            return C;
//        }
//    }
//}
