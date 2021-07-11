using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_home_work_8._7._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex 7
            Car c1 = new Car("Honda");
            c1.GetBrand();
            #endregion
            #region Ex8
            ConsolePlus console_Plus = new ConsolePlus("Daniel",26,1995);
            #endregion
            #region Ex 9
            Console.WriteLine("Enter size of Array");
            int size = int.Parse(Console.ReadLine());
            string[] myarray = new string[size];
            int[] myarray1 = new int[size];
            Random Agerandom = new Random();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter Name");
                person myperson = new person(Console.ReadLine());
                myarray[i] = myperson._Name;
                
                person myperson2 = new person(myarray[i], Agerandom.Next(1,101));
                myarray1[i] = myperson2._age;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"name: {myarray[i]}\nage {myarray1[i]}");

            }
            #endregion
        }

    }
    class Car
    {
        public string _Brand; // שם מותג הרכב
        public Car(string brand) // בנאי שמביא את מותג הרכב
        {
            _Brand = brand;
        }
        public  void GetBrand() // פונקציה שמדפיסה את שם המותג של הרכב
        {
            Console.WriteLine(_Brand);
        }
    }
    class ConsolePlus
    {
        public ConsolePlus()
        {
            Console.WriteLine("Default");
        }
        public ConsolePlus(string First) : this()
        {
            Console.WriteLine(First);
        }
        public ConsolePlus( string First,int num1 , int num2 ) : this(First)
        {
            Console.WriteLine(num1 + num2);
        }
    }
    class person
    {
        public int _age;
        public string _Name;
        public person(string Name)
        {
            _Name = Name;
        }
        public person(string Name, int age) : this(Name)
        {
            _age = age;
        }
    }
    

}
