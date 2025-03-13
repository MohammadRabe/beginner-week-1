using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAT_task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 numbers and get max

            //int[] numbers = new int[10];
            //for (int i = 0; i < 10; i++) {
            //    Console.WriteLine($"number[{i+1}] -> ");
            //    numbers[i] = int.Parse( Console.ReadLine() );
            //}
            //Array.Sort( numbers );
            //Console.WriteLine($"Maximum = {numbers[numbers.Length-1]}");
            #endregion

            #region Check if vowel

            //char letter = Console.ReadLine()[0];
            //if (letter == 'a' || letter == 'e' || letter == 'u' || letter == 'i' || letter == 'o')
            //    Console.WriteLine("Vowel");
            //else
            //    Console.WriteLine("Consonant");
            #endregion

            #region Multiplication Table of n
            //Console.WriteLine("Enter the number : ");
            //int n = int.Parse(Console.ReadLine());
            //int i =1 ;
            //while (i< 13)
            //{
            //    Console.WriteLine($"{n} x {i} = {n*i++}");
            //}

            #endregion

            #region Divisible by 3 and 4
            //Console.WriteLine("Enter the number : ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //if(n%12==0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");
            #endregion

            #region Decimal to Binary
            //StringBuilder revBinaryFormat = new StringBuilder();
            //StringBuilder binaryFormat = new StringBuilder();

            //int n = int.Parse(Console.ReadLine());
            //while (n != 0)
            //{
            //    revBinaryFormat.Append(n%2);
            //    n /= 2;
            //}
            //int length = revBinaryFormat.Length;
            //for (int i=0;i < length; i++)
            //    binaryFormat.Append(revBinaryFormat[length-i-1]);

            //Console.WriteLine(binaryFormat);
            #endregion

            #region Merge two sorted arrays

            //int[] arr1 = new int[] { 1, 5, 7, 10 };
            //int[] arr2 = new int[] { 2, 3, 6, 9 };    // the two arrays each is sorted 
            //int length = arr1.Length;
            //int[] merged = new int[length * 2];

            //int i = 0, j = 0, k = 0;
            //while (i < length && j < length)
            //{
            //    if (arr1[i] < arr2[j])
            //        merged[k++] = arr1[i++];
            //    else
            //        merged[k++] = arr2[j++];
            //}

            //while (i < length)
            //    merged[k++] = arr1[i++];

            //while (j < length)
            //    merged[k++] = arr2[j++];

            //foreach (int e in merged)
            //    Console.Write($"{e}, ");
            #endregion

            #region The second largest element

            //// i think its purpose is not to use Array.Sort()
            //int[] arr = { 12, 31, 23, 2, 5, 100, 99 }; // 99

            //for (int i = 0; i < arr.Length - 1; i++)
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int t = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = t;
            //        }
            //    }
            //Console.WriteLine(arr[arr.Length-2]);
            #endregion

            #region Reversed Array

            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //for(int i =arr.Length-1;i>-1;i--)
            //    Console.Write($"{arr[i]}, ");
            #endregion
        }
    }
}
