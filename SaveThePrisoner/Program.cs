using System;

namespace SaveThePrisoner
{
    class Program
    {
        public static int SaveThePrisoner(int n, int m, int s) {
            var prisonerToSave = (m + (s - 1)) % n;
            if (prisonerToSave == 0)
                return n;
            return prisonerToSave;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SaveThePrisoner(3, 7, 3));
        }
    }
}
