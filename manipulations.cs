using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Arrays
{
  
    class Manipulate
    {
        /***Counting, summing, computing the mean
            Write a method counts the number of elements in an integer array, and then sums the elements in an integer array.
            It should return the average of the array elements as a double. Using the count and sum, compute and print the mean of each array.*/

        public double Averaging(int[] array)
        {
            double total = 0;
            for (int x = 0; x < array.Length; x++)
            {
                total += array[x];
            }
            return total / array.Length;
        }

        /****Reversing arrays
       Write a method that accepts an array as an argument and prints the reversed array.
       For example, if you pass the method Array B, it should print[9, 7, 5, 3, 1]. 
       Print the reverse of all three arrays.*/

        public int[] Reverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = temp;
            }
            return array;
        }

        /****Rotating arrays
        Arrays can be rotated to the right or to the left by any number of places.Rotating an array to the right
        by two places puts the first element in position three, the second element in position four, and so on, with the last
        element in position two and the next to last element in position one. Array A rotated to the right by two places results
        in [8, 10, 0, 2, 4, 6]. Likewise, rotating an array to the left places the first elements at the end.Array B rotated to the
        left by two places results in [5, 7, 9, 1, 3]. Write a method that accepts three parameters, a direction
        (right or left), a number of places, and an array, which prints the appropriate rotation.Call the method on all three arrays.
         Rotate array A two places to the left. Rotate array B two places to the right. 
         Rotate array C four places to the left.*/

        public static int[] RotateLeft(int[] array)
        {
            for (int right = 0; right < 2; right++)
            {
                int tempArray = array[0];

                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[array.Length - 1] = tempArray;
            }
            return array;
        }

        public static int[] RotateRight(int[] array)
        {
            for (int left = 0; left > 2; left--)
            {
                int tempArray = array[0];

                for (int i = 0; i > array.Length - 1; i--)
                {
                    array[i] = array[i - 1];
                }
                array[array.Length + 1] = tempArray;
            }
            return array;
        }

        public static int[] ThreeParameters(int[] array, int direction, int numberOfIterations)
        {

            if (direction == 1)
            {
                for (int i = 0; i < numberOfIterations; i++)
                {
                    int tempArray = array[0];
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[array.Length - 1] = tempArray;
                }
            }

            else if (direction == 2)
            {
                for (int i = numberOfIterations; i >= 0; i--)
                {
                    int tempArray = array[0];
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    array[array.Length - 1] = tempArray;
                }
            }
            return array;
        }


        /****Sorting arrays
        Write a method that takes an unsorted integer array and prints a sorted array. 
        Use Array C as your test array. Do you recognize this list of numbers?*/

        public int[] Sort(int[] array)
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                for (int a = i + 1; a <= array.Length - 1; a++)
                {
                    if (array[i] > array[a])
                    {
                        int X = array[i];
                        array[i] = array[a];
                        array[a] = X;
                    }
                }
            }
            return array;
        }

        public static void Main()

        {

            int[] arr1 = { 6, 2, 8, 0, 10, 4 };          //arrays
            int[] arr2 = { 5, 1, 9, 3, 7 };
            int[] arr3 = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            MergeSort(arr3, 0, arr3.Length - 1);
            Console.WriteLine("Sorted Values:");
            for (int i = 0; i < arr3.Length; i++)
                Console.WriteLine(arr3[i]);

            Console.ReadLine();

        }



        private static void Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }

        public static void MergeSort(int[] input, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle);
                MergeSort(input, middle + 1, right);

                Merge(input, left, middle, right);
            }
        }

    }
}
