using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignerPdfViewer
{
    class Program
    {
        public static int DesignerPdfViewer(int[] h, string word) {
            var wordHeightList = new List<int>();
            foreach(var w in word) {
                var height = h[(int)w - 97];
                if(!wordHeightList.Contains(height))
                    wordHeightList.Add(height);
            }
            return wordHeightList.Max() * word.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DesignerPdfViewer(new int[] {1, 2, 1}, "ababab"));
        }
    }
}
