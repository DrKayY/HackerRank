using System;
using System.Collections.Generic;

namespace SequenceEquation
{
    class Program
    {
        public static int[] PermutationEquation(int[] p) {
            var yArray = new int[p.Length];
            var aList = new List<int>();

            for (int i = 0 ; i < p.Length ; i++) {
                aList.Add(p[i]);
            }

            for (int x = 1 ; x <= p.Length ; x++) {
                var firstIndex = aList.FindIndex(a => a.Equals(x)) + 1;
                yArray[x - 1] = aList.FindIndex(a => a.Equals(firstIndex)) + 1;
            }

            return yArray;
        }
        static void Main(string[] args)
        {
                foreach (var a in PermutationEquation(new int[] {4, 3, 5, 1, 2})) {
                    Console.WriteLine(a);
                }
        }
    }
}
