using System;
using System.Collections.Generic;

namespace IntroToTutorialChallenges
{
    class Program
    {
        public static int IntroTutorial(int V, int[] arr) {
            var i = 0;
            while (true) {
                if (arr[i] == V)
                    break;
                i++;
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IntroTutorial(4, new int[] {1, 4, 5, 7, 9, 12}));
        }
    }
}
