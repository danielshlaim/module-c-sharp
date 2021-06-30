using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_28._6._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            fanctions1("daniel", "shlaim");
            Console.WriteLine("your age " + age(26));
            login();
            
            
            
        }
        public static void fanctions1(string name, string last)
        {
            Console.WriteLine(name + " " + last);
            Console.WriteLine("");

        }
        public static int age(int age)
        {
            return age;
        }
        public static bool user_pass(string username, string password)
        {
            if (username == "daniel" && password == "dan123")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static void login()
        {
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password = Console.ReadLine();
            if (user_pass(username, password))
            {
                Console.WriteLine("welcome");

            }
            else
            {
                Console.WriteLine("worng password or username");
            }
        }

    }
}
