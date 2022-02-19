using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day6
{
    internal class ArrayDemo2
    {

        //public static void Display(int[,] arr)
        public static void Display(int[][] arr)
        {
            Console.WriteLine("matrix values are:");
            //for (int r = 0; r <= arr.GetUpperBound(0); r++)
            for (int r = 0; r < arr.Length; r++)
            {
                //for (int c = 0; c <= arr.GetUpperBound(1); c++)
                for (int c = 0; c <  arr[r].Length; c++)
                {
                    Console.WriteLine($"{arr[r][c]}\t");

                }
                Console.WriteLine();

            }
        }

        static void Main(string[] args)
        {

            // int[,] arr = new int[3, 4];
            int[,] arr = new int[3, 4]
            {
               {1, 2, 3,4 },
               {5,6,7,8},
               {9,10,11,12}

               };
            Console.WriteLine("Rank:" + arr.Rank);
           //Display(arr);

            //    Console.WriteLine("matrix values are:");
            //    for (int r = 0; r <= arr.GetUpperBound(0); r++)
            //    {
            //        for (int c = 0; c <=arr.GetUpperBound(1) ; c++)
            //        {
            //            Console.WriteLine($"{arr[r,c]}\t");

            //        }
            //        Console.WriteLine();

            //    }
            //}

            //int[][] jagged = new int[4][]; //4-1d array
            //jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            //jagged[1] = new int[3] { 6, 7, 8 };
            //jagged[2] = new int[2] { 9, 10 };
            //jagged[3] = new int[4] {11,12,13,14};

            int[][] jagged = new int[4][]
            {
                new int[5]{1,2,3,4,5},
                new int[3] { 6, 7, 8 },
                new int[2] { 9, 10 },
                new int[4] {11,12,13,14}
             };
            Console.WriteLine("Rank:"+jagged.Rank);//1
            Console.WriteLine("Length :"+jagged.Length);//4
            Console.WriteLine(jagged[0].Length);//5
            Console.WriteLine(jagged[0].Rank);//1
            Display(jagged);

            //jagged 2-D array
            int[][,] jagged2D = new int[4][,]//4 2D array
            {
                new int[3, 3] {{ 1, 2, 3 }, { 4, 5, 6 },{ 7,8,9} },//9,2
                new int[2, 2] { { 1, 2 }, { 3, 4 } }, //4,2
                new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } },//6,2
                new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }//16,2
            };
            //displaying jagged array data using foreach

            Console.WriteLine("Jagged 1-D array data using foreach:");

            //foreach(int[]row  in jagged)
            //foreach (var row in jagged)
            //{
            //    foreach(var item in row)
            //    {
            //        Console.WriteLine(item +"\t");
            //    }
            //    Console.WriteLine();
            //}

            int count = 0;
            Console.WriteLine("Jagged 2-D array data using foreach:");
            foreach (int[,] row in jagged2D)
            {
                int len = row.GetLength(1);//3,2,4
                Console.WriteLine("Matrix:\n");
                foreach (var item in row)
                {
                    Console.Write(item+"\t");
                    count++;
                    if(count == len)
                    {
                        Console.WriteLine();
                        count= 0;
                    }

                }
                Console.WriteLine();

            }
            
            
        }
    }
}
