using System;

namespace CircularArrayRotation
{
    class Program
    {
        public static int[] CircularArrayRotation(int[] a, int k, int[] queries) {
            var newArray = new int[a.Length];
            var response = new int[queries.Length];
            for (var i = 0 ; i < a.Length ; i++) {
                newArray[(i + k) % a.Length] = a[i];
            }
            for (var i = 0 ; i < queries.Length ; i++) {
                response[i] = newArray[queries[i]];
            }
            return response;
        }
        static void Main(string[] args)
        {
            foreach (var r in CircularArrayRotation(new int[] {3, 4, 5}, 2, new int[] {1, 2}))
                Console.WriteLine(r);
        }
    }
}
