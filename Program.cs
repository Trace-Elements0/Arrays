using System;
using System.ComponentModel;
using System.Threading.Channels;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            Manipulate j = new Manipulate();

            int[] arrayA = { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = { 1, 3, 5, 7, 9 };
            int[] arrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //double avgA = j.Averaging(arrayA);
            //double avgB = j.Averaging(arrayB);
            //double avgC = j.Averaging(arrayB);

            //Console.WriteLine($"Average of Array A is: {avgA}.");
            //Console.WriteLine($"Average of Array B is: {avgB}.");
            //Console.WriteLine($"Average of Array C is: {avgC}.");

            //int[] a = j.Reverse(arrayA);
            //int[] b = j.Reverse(arrayB);
            //int[] c = j.Reverse(arrayC);

            //Console.WriteLine(string.Join(", ", a));
            //Console.WriteLine(string.Join(", ", b));
            //Console.WriteLine(string.Join(", ", c));

            //int[] sortedC = j.Sort(arrayC);
            //Console.WriteLine(string.Join(", ", sortedC));

            //double avgA = m.Averaging(arrayA);
            //double avgB = m.Averaging(arrayB);
            //double avgC = m.Averaging(arrayB);

            //Console.WriteLine($"Average of Array A is: {avgA}.");
            //Console.WriteLine($"Average of Array B is: {avgB}.");
            //Console.WriteLine($"Average of Array C is: {avgC}.");

            bool left = true;
            int places;
            int[] A = j.Rotated(2, arrayA);
            Console.WriteLine(string.Join(", ",A));


        }
    }
}
