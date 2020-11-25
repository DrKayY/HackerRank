using System;
using System.Collections.Generic;

namespace ElectronicsShop
{
    class Program
    {
        static int GetMoneySpent(int[] keyboards, int[] drives, int b)
        {
            var totalPricesPossible = new List<int>() {};

            foreach (var k in keyboards) {
                foreach (var d in drives) {
                    if ((k + d) <= b)
                        totalPricesPossible.Add(k + d);
                }
            }

            totalPricesPossible.Sort();

            return totalPricesPossible.Count != 0 ? totalPricesPossible[totalPricesPossible.Count - 1] : -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMoneySpent(new int[] {3, 1}, new int[] {5, 2, 8}, 10));
            Console.WriteLine(GetMoneySpent(new int[] {4}, new int[] {5}, 5));
        }
    }
}
