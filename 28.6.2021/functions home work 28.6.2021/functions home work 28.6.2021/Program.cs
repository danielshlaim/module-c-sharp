using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_home_work_28._6._2021
{
    class Program
    {
        #region Ex1
        //    static void Main(string[] args)
        //    {
        //        int choice = int.Parse(Console.ReadLine());
        //        NumBt1_10(choice);
        //    }
        //    public static void NumBt1_10(int num)
        //    {
        //        switch (num)
        //        {
        //            case 1:
        //                Console.WriteLine("one");
        //                break;
        //            case 2:
        //                Console.WriteLine("two");
        //                break;
        //            case 3:
        //                Console.WriteLine("three");
        //                break;
        //            case 4:
        //                Console.WriteLine("four");
        //                break;
        //            case 5:
        //                Console.WriteLine("five");
        //                break;
        //            case 6:
        //                Console.WriteLine("six");
        //                break;
        //            case 7:
        //                Console.WriteLine("seven");
        //                break;
        //            case 8:
        //                Console.WriteLine("eight");
        //                break;
        //            case 9:
        //                Console.WriteLine("nine");
        //                break;
        //            case 10:
        //                Console.WriteLine("ten");
        //                break;

        //            default:
        //                Console.WriteLine("only number between 1 to 10");
        //                break;


        //        }
        //    }
        #endregion
        #region Ex2
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number ");
        //    int get = int.Parse(Console.ReadLine());
        //    Add_Numbers(get);
        //    bool x = CheckOneToTen(get);
        //    Console.WriteLine(x);


        //}
        //public static void OnetoTen()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        //public static void Add_Numbers(int num)
        //{
        //    for (int i = 1; i <= num; i++)
        //    {
        //        Console.WriteLine(i);
        //    }

        //}
        //public static bool CheckOneToTen(int number1)
        //{
        //    if (number1 <= 10)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;

        //}

        #endregion
        #region Ex1 challenge accepted!
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number");
        //    int num = int.Parse(Console.ReadLine());
        //    GetNum(num);
        //}
        //public static void GetNum(int num)
        //{
        //    if(num != 10)
        //    {
        //    Console.WriteLine(num);
        //    Console.WriteLine("Enter number");
        //    int num1 = int.Parse(Console.ReadLine());
        //    GetNum(num1);
        //    }

        //}
        #endregion
        #region Ex3
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter number");
        //    int number = int.Parse(Console.ReadLine());
        //      int x = getnumber(number);
        //    Console.WriteLine(x);
        //}
        //public static int getnumber(int number)
        //{
        //    int counter = 0;
        //    for (int i = 1; i < number; i++)
        //    {
        //        if (number %i == 0)
        //        {
        //            counter += 1;
        //        }
        //    }
        //    if (counter > 2)
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}
        #endregion
        #region Ex4
        //static void Main(string[] args)
        //{
        //    int[] Arr= new int [5]{ 17, 13, 9, 4, 2};
        //    MyarrNumber(Arr);
        //}
        //public static void MyarrNumber(int[] Arr)
        //{
        //    for (int i = 0; i < Arr.Length; i++)
        //    {
        //        int counter = 0;
        //        for (int j = 1; j <= Arr[i]; j++)
        //        {
        //            if (Arr[i] % j == 0);
        //            {
        //                counter += 1;
        //            }

        //        }
        //        if (counter > 2)
        //        {
        //            Console.WriteLine("its not prime");
        //        }
        //        else
        //        {
        //            Console.WriteLine("its prime");
        //        }

        //    }
        //}

        #endregion
        #region Ex5
        //static void Main(string[] args)
        //{
        //    int[] Myarr1 = new int[5] { 3, 5, 9, 1, 2 };
        //    int[] Myarr2 = new int[5] { 6, 3, 7, 4, 8 };
        //     int x = DoubleArr(Myarr1, Myarr2);
        //    Console.WriteLine(x);
        //}
        //public static int DoubleArr(int[] Myarr1, int[] Myarr2)
        //{
        //    int sum1 = 0;
        //    int sum2 = 0;
        //    for (int i = 0; i < Myarr1.Length; i++)
        //    {
        //        sum1 += Myarr1[i];
        //    }
        //    for (int j = 0; j < Myarr2.Length; j++)
        //    {
        //        sum2 += Myarr2[j];
        //    }
        //    if (sum1 > sum2)
        //    {
        //        return 1;
        //    }
        //    else if (sum1 < sum2)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        
        #endregion
        
    }
}
