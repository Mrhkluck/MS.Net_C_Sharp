using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{
    internal class ArrayDemo1
    {
        static void Main(string[] args)
        {
            //Normal Array
            //int[] arr;//Decln []must be at left
            //arr = new int[5];//Decln+intialization with default valu
            //int[] arr = new int[5]; //no of element stored in array
            // int[,] arr = new int[5,4];
            //int[,,] arr = new int[5,4,5];
            //Console.WriteLine(arr.Length);//no of element stored in array
            //Console.WriteLine(arr.Rank);//Dimension of array

            //Console.WriteLine(arr.GetUpperBound(0));//4
            //Console.WriteLine(arr.GetUpperBound(1));//3
            //Console.WriteLine(arr.GetUpperBound(2));//4 

            //Console.WriteLine(arr.GetLength(0));//5 only for 2d or 3d array
            //Console.WriteLine(arr.GetLength(1));//4
            //Console.WriteLine(arr.GetLength(2));//5


            int [] arr = { 10, 2, 3, 40, 5, 60 };
            //int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Arrays element are");
            //for (int i = 0; i < 7; i++) Index was outside the bounds of the array.
            // for (int i = 0; i < 6; i++)
            //for (int i = 0; i < arr.GetLength(0); i++)
            //for (int i = 0; i <=arr.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //Console.WriteLine("Input array Valurs");
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    Console.WriteLine($"Enter element {i+1} value:");
            //    arr[i] = Int32.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Current Arrays element are:");
            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());

            Array.Sort(arr);
            //Array.Reverse(arr);
            Console.WriteLine("Sorted Array element are:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //int res = Array.BinarySearch(arr, 60);
            int x = 60;
            bool res =arr.Contains(x);
            Console.WriteLine("result:"+res);


            //int[] arr2 = {10,20,30,40,50,60};
            int[] arr2 = arr;
            int result = Array.BinarySearch<int>(arr,x);
            Console.WriteLine("Result:"+result);

        }
    }
}
