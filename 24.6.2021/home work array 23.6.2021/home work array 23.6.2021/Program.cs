using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_array_23._6._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            //int[] myarr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int trycounter = 0;
            //int trys = 0;
            //for (int i = 0; i < myarr.Length; i++)
            //{

            //        while (trys <= 30)
            //       {
            //        Console.WriteLine("Enter number ");
            //        int num = int.Parse(Console.ReadLine());
            //        if (Array.IndexOf(myarr, num) == i)
            //       {
            //            Console.WriteLine("you find the number after  " + trycounter);
            //            trycounter = 0;
            //            break;
            //       }
            //        else
            //       {
            //            Console.WriteLine("you worng");
            //            trycounter += 1;
            //            trys += 1;
            //            continue;
            //       }


            //     }

            //}
            //if (trys > 30)
            //{
            //    Console.WriteLine("Game Over!");
            //}
            //else
            //{
            //    Console.WriteLine( "you finish the Game "  + trys );
            //}
            #endregion

            #region Ex2
            //int[,] myarr1 = new int[5, 5] { { 1, 3, 7, 0, 3 }, { 2, 1, 7, 3, 9 }, { 3, 1, 8, 3, 4 }, { 4, 0, 1, 4, 2 }, { 9, 1, 4, 3, 8 } };
            //int x = int.Parse(Console.ReadLine());
            //for (int i = 0; i < myarr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < myarr1.GetLength(1); j++)
            //    {
            //        if (x == myarr1[i, j])
            //        {
            //            Console.WriteLine("the val is exist in row " + (i+1)  + " and in column " + (j+1));
            //        }

            //    }
            //}
            #endregion

            #region ex3
            //int[,] multi = new int[10, 10];
            //for (int i = 0; i <multi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multi.GetLength(1); j++)
            //    {
            //        multi[i, j] = (i + 1) * (j + 1);
            //        Console.Write(multi[i,j] + "\t");
            //    }
            // Console.WriteLine();
            //}
            #endregion
            #region ex 4
            //int[,] myarr2 = new int[3, 3] { { 0, 1, 0 }, { 1, 1, 0 }, { 1, 0, 1 } };
            //int counter = 0;
            //int check;
            //while (true)
            //{
            //    check = 0;
            //    for (int i = 0; i < myarr2.GetLength(0); i++)
            //    {
            //        for (int j = 0; j <myarr2.GetLength(1); j++)
            //        {
            //            if (myarr2[i, j] == 1)
            //            {
            //                check += 1;
            //            }

            //        }
            //    }
            //    if (check != 0)
            //    {
            //     int line = int.Parse(Console.ReadLine());
            //     int length = int.Parse(Console.ReadLine());

            //        if (myarr2[line - 1, length - 1] == 1)
            //        {
            //            myarr2[line - 1, length - 1] = 0;
            //            Console.WriteLine("Boom!");
            //        }
            //        else
            //        {
            //            Console.WriteLine("you Miss!");
            //             counter += 1;

            //        }

            //    }
            //    else
            //        break;




            //}
            //Console.WriteLine(" Game Over\ntrys"  + counter);

            #endregion
            #region Ex5
            //int[,,] my3D = new int[2, 2 ,2];
            //for (int i = 0; i <my3D.GetLength(0); i++)
            //{
            //    for (int j = 0; j <my3D.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < my3D.GetLength(2); k++)
            //        {
            //            my3D[i, j, k] = int.Parse(Console.ReadLine());
            //        }
            //    }
            //}
            //for (int i = 0; i < my3D.GetLength(0); i++)
            //{
            //    for (int j = 0; j < my3D.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < my3D.GetLength(2); k++)
            //        {
            //            Console.WriteLine(my3D[i, j, k]);
            //        }
            //    }
            //}

            #endregion
            #region Ex6
            //int[,] arr2D = new int[6, 4];
            //for (int i = 0; i < arr2D.GetLength(0); i++)
            //{
            //    for (int j = 0; j <arr2D.GetLength(1) ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //Console.WriteLine();
            //}
            #endregion
            #region Ex7
            //int[][] myarr2D = new int[3][];
            //myarr2D[0] = new int[2];
            //myarr2D[1] = new int[2];
            //myarr2D[2] = new int[2];
            //for (int i = 0; i < myarr2D.Length; i++)
            //{
            //    for (int j = 0; j < myarr2D[i].Length ; j++)
            //    {
            //        myarr2D[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < myarr2D.Length; i++)
            //{
            //    for (int j = 0; j < myarr2D[i].Length; j++)
            //    {
            //        Console.WriteLine(myarr2D[i][j]);
            //    }
            //}
            #endregion
            #region Ex8
            Console.WriteLine("Enter number of classes");
            int numberOfClass = int.Parse(Console.ReadLine());
            int[][] classes = new int[numberOfClass][];
            int[] avgclass = new int[numberOfClass];
            int sum;
            int avg;
            int bigavg = 0;
            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("Enter number of students in class "+ (i +1) );
                classes[i] = new int[int.Parse(Console.ReadLine())];
            }
            for (int i = 0; i < classes.Length; i++)
            {
                for (int j = 0; j < classes[i].Length; j++)
                {
                    Console.WriteLine("Enter grade for student " + (j+1)  + " in class " + (i+1));
                    classes[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int a = 0; a < classes.Length; a++)
            {
                sum = 0;
                for (int i = 0; i < classes[a].Length; i++)
                {
                    sum += classes[a][i];
                }
                avg = sum / classes[a].Length;
                avgclass[a] = avg;
                if (avg > bigavg)
                {
                    bigavg = avg;
                }
            }
            Console.WriteLine("the  class with the high avg is class " + (Array.IndexOf(avgclass,bigavg) +1 ) + " with the avg " + bigavg);
            #endregion


        }
    }
}