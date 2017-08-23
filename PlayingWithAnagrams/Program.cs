using System;
using System.Linq;

namespace PlayingWithAnagrams
{
    class Program
    {
        static int[] getMinimumDifference(string[] a, string[] b)
        {
            var differences = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                differences[i] = a[i].Length != b[i].Length ? -1 : differences[i];
                differences[i] = a[i].Length == b[i].Length && a[i].Contains(b[i]) ? 0 : differences[i];
                differences[i] = differences[i] == 0 ? a[i].Count(letter => !b[i].Contains(letter)) : differences[i];
            }
            return differences;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of elements of the A array");
            int numOfElementsInA = Convert.ToInt32(Console.ReadLine());

            var numOfCharsInA = new string[numOfElementsInA];
            Console.WriteLine("Next write the elements of the A array");
            for (int e = 0; e < numOfElementsInA; e++)
            {
                numOfCharsInA[e] = Console.ReadLine().ToLower();
            }

            var numOfCharsInB = new string[numOfElementsInA];
            Console.WriteLine("Next write the elements of the B array");
            for (int e = 0; e < numOfElementsInA; e++)
            {
                numOfCharsInB[e] = Console.ReadLine().ToLower();
            }

            var result = getMinimumDifference(numOfCharsInA, numOfCharsInB);

            Console.WriteLine(String.Join(",", result));
            Console.ReadLine();
        }
    }
}
