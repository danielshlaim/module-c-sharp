using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_override_and_virtual_home_work
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal ani = new Animal();
            //ani.Drink();
            //dog snow = new dog();
            //snow.Drink();

            // Vehicle onlyBase = new Vehicle();
            // onlyBase.OpenOrCloseRoof();
            // onlyBase.AddWheel();
            // Vehicle baseWithCar = new Car();
            // baseWithCar.OpenOrCloseRoof();
            // baseWithCar.AddWheel();
            // Vehicle baseWithMotor = new Motorcycle();
            //baseWithMotor.AddWheel();
            //baseWithMotor.OpenOrCloseRoof();
            // Car onlyCar = new Car();
            // onlyCar.OpenOrCloseRoof();
            // onlyCar.AddWheel();
            // Motorcycle onlyMotor = new Motorcycle();
            // onlyMotor.AddWheel();
            // onlyMotor.OpenOrCloseRoof();

            Person P = new Person(0395834921);
            Person p1 = new Person(014838674);
            Person p5 = new Person(014838674);

            P.Checker(p1.Id);
            p1.Checker(P.Id);
            Person1 p2 = new Person1(312312123, "daniel", "Shlaim");
            Person1 p3 = new Person1(123124563, "gil", "alkobi");
            Person1 p4 = new Person1(123124563, "gil", "alkobi");
            p1.Checker(p2.Id);
            p2.Checker(p1.Id);
            p3.Checker(p4.Name, p4.lastName);
            p4.Checker(p2.Name, p2.lastName);
        }


    }
    #region Ex 2
    class Animal
    {
        public virtual void Drink()
        {
            Console.WriteLine(" i was thirsty ");
        }


    }
    class dog : Animal
    {
        public override void Drink()
        {

            Console.WriteLine(" im not thirsty");
        }
    }
    #endregion
    #region Ex3
    class Vehicle
    {
        public int NumberOfwheel;
        public string Color;
        public bool IfRoofOpen;

        public virtual void AddWheel()
        {
            if (NumberOfwheel < 4)
                NumberOfwheel++;
            Console.WriteLine(NumberOfwheel);

        }
        public void OpenOrCloseRoof()
        {
            if (!IfRoofOpen)
            {
                this.IfRoofOpen = true;
            }
            else
            {
                this.IfRoofOpen = false;
            }

        }

    }
    class Car : Vehicle
    {

    }
    class Motorcycle : Vehicle
    {
        public override void AddWheel()
        {
            if (NumberOfwheel < 2)
            {
                NumberOfwheel++;

            }
            Console.WriteLine(NumberOfwheel);
        }
        public new void OpenOrCloseRoof()
        {
            Console.WriteLine("on motorcycle the roof is always open");
        }



    }



    #endregion
    #region Ex Challenge
    class Person
    {
        public int Id;
        public Person(int Id)
        {
            this.Id = Id;
        }
        public virtual void Checker(int id)
        {
            if (this.Id == id)
            {
                Console.WriteLine("this is the same person");
            }
            else
            {
                Console.WriteLine("you are not the same person");
            }

        }
    }
    class Person1 : Person
    {
        public string Name;
        public string lastName;
        public Person1(int Id, string name, string lastname) : base(Id)
        {
            this.Name = name;
            this.lastName = lastname;
        }
        public override void Checker(int id)
        {
            Console.WriteLine("we cant do this , We cheack only  name and lastname ");
        }
        public void Checker(string name, string lastname)
        {
            if (this.Name == name && this.lastName == lastname)
            {
                Console.WriteLine("this is the same person");
            }
            else
            {
                Console.WriteLine("this is not the same person");
            }

        }
    }


    #endregion

}
