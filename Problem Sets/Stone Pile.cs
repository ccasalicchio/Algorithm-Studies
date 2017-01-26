using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

/// <summary>
/// From http://acm.timus.ru/problem.aspx?space=1&num=1005
/// Time limit: 1.0 second
/// Memory limit: 64 MB
/// You have a number of stones with known weights w1, …, wn.Write a program that will rearrange the stones into two piles such that weight difference between the piles is minimal.
/// Input
/// Input contains the number of stones n(1 ≤ n ≤ 20) and weights of the stones w1, …, wn(integers, 1 ≤ wi ≤ 100000) delimited by white spaces.
/// Output
/// Your program should output a number representing the minimal possible weight difference between stone piles.
/// input   
/// 5
/// 5 8 13 27 14
/// output
/// 3
/// Problem Source: USU Championship 1997
/// Tags: problem for beginners
/// Difficulty: 92 
/// </summary>
namespace Algorithms
{
    public class Stone_Pile
    {
        public void Run(TextReader reader, TextWriter writer)
        {
            //First line = number of stones
            int numberOfStones = int.Parse(reader.ReadLine());

            //Second line = weights of stones
            List<int> weights = ParseStones(reader.ReadLine());

            writer.Write(SortPiles(weights, numberOfStones));

            reader.ReadLine();

        }
        public List<int> ParseStones(string stones)
        {
            return stones.Split(' ').Select(Int32.Parse).ToList();
        }
        public int SortPiles(List<int> weights, int numberOfStones)
        {
            int pileOne, pileTwo;

            pileOne = 0;
            pileTwo = 0;

            //Sort by lowest weight
            weights.Sort();

            return -1;

        }
        public static void Main()
        {
            new Stone_Pile().Run(Console.In, Console.Out);
        }
    }
}
