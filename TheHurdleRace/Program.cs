using System;
using System.Linq;

namespace TheHurdleRace
{
    class Program
    {
        public static int HurdleRace(int k, int[] height) {
            var maxHeight = height.Max();
            if(maxHeight > k)
                return maxHeight - k;

            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(HurdleRace(7, new int[] {2, 5, 4, 5, 2}));
        }
    }
}
