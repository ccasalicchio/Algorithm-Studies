//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace Algorithms
//{
//    class Knapsack
//    {
//        double bestValue;
//        bool[] bestItems;
//        double[] itemValues;
//        double[] itemWeights;
//        double weightLimit;

//        void SolveRecursive(bool[] chosen, int depth, double currentWeight, double currentValue, double remainingValue)
//        {
//            if (currentWeight > weightLimit) return;
//            if (currentValue + remainingValue < bestValue) return;
//            if (depth == chosen.Length)
//            {
//                bestValue = currentValue;
//                System.Array.Copy(chosen, bestItems, chosen.Length);
//                return;
//            }
//            remainingValue -= itemValues[depth];
//            chosen[depth] = false;
//            SolveRecursive(chosen, depth + 1, currentWeight, currentValue, remainingValue);
//            chosen[depth] = true;
//            currentWeight += itemWeights[depth];
//            currentValue += itemValues[depth];
//            SolveRecursive(chosen, depth + 1, currentWeight, currentValue, remainingValue);
//        }

//        public bool[] Solve()
//        {
//            var chosen = new bool[itemWeights.Length];
//            bestItems = new bool[itemWeights.Length];
//            bestValue = 0.0;
//            double totalValue = 0.0;
//            foreach (var v in itemValues) totalValue += v;
//            SolveRecursive(chosen, 0, 0.0, 0.0, totalValue);
//            return bestItems;
//        }
//    }
//}
