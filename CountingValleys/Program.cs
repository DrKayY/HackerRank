using System;

namespace CountingValleys
{
    class Program
    {
        public static int CountingValleys(int steps, string path){
            // We only bother about when the body goes back up to sea level
            int level = 0, count = 0;

            foreach(var p in path){
                if (p == 'D')
                    level--;

                else {
                    level++;
                    if (level == 0)
                        count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CountingValleys(8, "UDDDUDUU"));
        }
    }
}
