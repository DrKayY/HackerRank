using System;

namespace CountingValleys
{
    class Program
    {
        public static int CountingValleys(int steps, string path){
            int level = 0, count = 0;
            bool startedCount = false, balancedCount = false;

            foreach(var p in path){
                var currentLevel = level;
                if (p == 'D')
                    level--;
                else 
                    level++;
                
                if (currentLevel == 0 && level == -1 || balancedCount)
                    startedCount = true;

                if (currentLevel == -1 && level == 0 && startedCount){
                    balancedCount = true;
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
