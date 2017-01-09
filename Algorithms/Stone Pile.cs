//using System;
//using System.IO;

///// <summary>
///// From http://acm.timus.ru/problem.aspx?space=1&num=1005
///// Find the total possible combinations for the number of stones and create that number of piles
///// Create an array with all possible weights and sort by weight, get the lowest value
///// Still not right, use napsac problem
///// </summary>
//namespace Algorithms
//{
//    public class Stone_Pile
//    {
//        private int numberOfStones;
//        private int[] stones;

//        public void Run(TextReader reader, TextWriter writer)
//        {
//            numberOfStones = int.Parse(reader.ReadLine());
//            string[] weights = reader.ReadLine().Split(' ');

//            stones = new int[numberOfStones];

//            for (int i = 0; i < stones.Length; i++)
//                stones[i] = int.Parse(weights[i]);

//            stones = SortStonesByWeight(stones);

//            int sizeOfPiles = (int)Math.Ceiling((numberOfStones / 2.0));
//            int pileOneWeight = 0, pileTwoWeight = 0;

//            for (int i = stones.Length - 1; i >= 0; i--)
//            {
//                if (pileOneWeight <= pileTwoWeight || pileOneWeight == pileTwoWeight)
//                    pileOneWeight += stones[i];
//                else
//                    pileTwoWeight += stones[i];
//            }

//            writer.WriteLine((int)Math.Abs(Math.Round(pileOneWeight - pileTwoWeight / 1.0)));
//        }

//        public int[] SortStonesByWeight(int[] stones)
//        {
//            for (int i = 1; i < stones.Length; i++)
//            {
//                int weight = stones[i];
//                if (weight < stones[i - 1])
//                {
//                    stones[i] = stones[i - 1];
//                    stones[i - 1] = weight;
//                }
//            }
//            return stones;
//        }
//        public static void Main()
//        {
//            new Stone_Pile().Run(Console.In, Console.Out);
//        }
//    }
//}
