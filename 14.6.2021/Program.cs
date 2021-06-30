using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myFirstProject;

namespace myFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Your Age:");
            int age = int.Parse(Console.ReadLine());
            int x = 1;//int.Parse(Console.ReadLine());

            switch (age)
            {
                case 3:
                case 2:
                case 1:
                    Console.WriteLine("Dora");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Read Book");
                    break;
                case 20:
                case 21:
                case 22:
                    Console.WriteLine("Open Visual Studio");
                    break;
                default:
                    Console.WriteLine("Turn Off");
                    break;
            }
        }
    }
}
