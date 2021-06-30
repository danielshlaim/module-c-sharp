using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region array ex1
            //int[] intarr = new int[10] { 3, 7, 23, 33, 88, 2, 6, 9, 11, 1 };
            //for (int c = 0; c < intarr.Length; c++)
            //{
            //    if (intarr[c] % 2 == 0)
            //        Console.WriteLine(intarr[c]);
            //}
            //#endregion


            //#region array ex2 
            //int[] arr1 = new int[10];
            //int[] arr2 = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Enter number1");
            //    int array1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter number2");
            //    int array2 = int.Parse(Console.ReadLine());
            //    arr1[i] = array1;
            //    arr2[i] = array2;

            //}
            //for (int y = 0; y < 10; y++)
            //{
            //    if (arr1[y] > arr2[y])
            //        Console.WriteLine("arr1 higher then arr2 {0}", arr1[y]);
            //    else if (arr1[y] < arr2[y])
            //        Console.WriteLine("arr2 higher then arr1 {0}", arr2[y]);
            //    else
            //        Console.WriteLine("they are even");


            //}
            //#endregion

            //#region home work1
            //int[] x = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Enter number");
            //    int y = int.Parse(Console.ReadLine());
            //    x[i] = y;
            //}
            //for (int z = 9; z >= 0; z--)
            //{
            //    Console.WriteLine(x[z]);

            //}
            //#endregion

            //#region home work2
            //int[] x1 = new int[5] { 2, 4, 6, 1, 9 };
            //Console.WriteLine("1:{0}\n2:{1}\n3:{2}\n4:{3}\n5:{4}", x1[0],x1[1],x1[2],x1[3],x1[4]);
            //#endregion

            //#region home work3
            //int[] x2 = new int[10];
            //int[] y2 = new int[10];
            //for (int i = 0; i < 10 ; i++)
            //{
            //    Console.WriteLine("Enter number");
            //    int r = int.Parse(Console.ReadLine());
            //    x2[i] = r;
            //    y2[i] = x2[i];
            //}
            //for (int i1 = 0; i1 < 10; i1++)
            //{
            //    Console.WriteLine("x2:{0}\n y2:{1}",x2[i1],y2[i1]);
            //}
            //for (int z = 0; z < 10; z++)
            //{
            //    Console.WriteLine("Enter number");
            //    x2[z] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("x2:{0}\n y2:{1}", x2[z], y2[z]);

            //}
            //#endregion

            //#region home work4 + 5
            //int[] x2 = new int[10];
            //int[] y2 = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Enter number");
            //    int r = int.Parse(Console.ReadLine());
            //    x2[i] = r;
            //}
            //    y2 = x2;
            //for (int i1 = 0; i1 < 10; i1++)
            //{
            //    Console.WriteLine("x2:{0}\n y2:{1}", x2[i1], y2[i1]);
            //}
            //for (int z = 0; z < 10; z++)
            //{
            //    Console.WriteLine("Enter number");
            //    x2[z] = int.Parse(Console.ReadLine());
            //    Console.WriteLine("x2:{0}\n y2:{1}", x2[z], y2[z]);
            //}
            //#endregion



            //#region home work 
            //int total = 0;
            //Console.WriteLine("enter number of students");
            //int stu = int.Parse(Console.ReadLine());
            //int[] Class = new int[stu]; 
            //for (int i = 0; i < Class.Length; i++)
            //{
            //    Console.WriteLine("Enter grade");
            //    int grade = int.Parse(Console.ReadLine());
            //    Class[i] = grade;
            //}
            //for (int x3 = 0; x3 < Class.Length ; x3++)
            //{
            //    total += Class[x3];
            //}
            //Console.WriteLine("total:{0}, avg:{1}",total,total/stu);
            //#endregion

        }



    }
}

