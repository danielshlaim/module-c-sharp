using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_8._7._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex8 computer
            //Computer c1 = new Computer();
            //c1.TellMePrice(500);
            //c1.TellMeScreenSize(60);
            //c1.AddProcessor(5);
            //c1._model = "lenovo";
            //c1.TurnOn();
            //c1.TurnOff();
            //Console.WriteLine(c1.OverRide());

            //Computer c2 = new Computer();
            //c2.TellMePrice(1000);
            //c2.TellMeScreenSize(90);
            //c2._model = "Apple";
            //c2.AddProcessor(10);
            //c2.TurnOn();


            //Computer c3 = new Computer();
            //c3._model = "Samsung";
            //c3.TellMeScreenSize(70);
            //c3.AddProcessor(8);
            //c3.TellMePrice(899);
            //c3.TurnOn();
            //c3.TurnOff();
            #endregion
            #region Ex9 Table
            //Table T1 = new Table();  // בנאי ריק הגדרה רגילה ,מגדירים ערכים מחוץ
            //T1._NumberOfLegs = 4;
            //T1._ColorOfTable = "brown";
            //T1._Type = "Alon";
            //Table T2 = new Table(4,"brown","Alon"); // בנאי סטנדרטי מגדירים ערכים מראש
            //Table T3 = new Table //  בנאי מקבל ערכים על פי הוראות יצרן
            //{
            //    _NumberOfLegs = 4,
            //    _ColorOfTable = "brown",
            //    _Type = "Alon"
            //};
            //Table T4 = T2;

            #endregion
            #region Ex 10
            Octagon oc1 = new Octagon(10, 5);

            #endregion
        }

    }
    class Computer
    {
        public string _model;
        public int _price;
        public int _numberofprocessors;
        public float _screensize;
        public bool _isturnOn;


        public  void TellMePrice(int price)
        {
            _price = price;
        }

        public void TellMeScreenSize(float screenSize)
        {
            _screensize = screenSize;
        }

        public void TurnOn()
        {
            _isturnOn = true;
        }

        public void TurnOff()
        {
            _isturnOn = false;
        }

        public string OverRide()
        {
            return ToString();
        }

        public void AddProcessor(int Processors)
        {
            _numberofprocessors = Processors; 
        }
        
    }
    class Table
    {
        public int _NumberOfLegs;
        public string _ColorOfTable;
        public string _Type;

        public Table() // T1,T3
        {
           
        }

        public Table(int numberoflegs, string color,string type) //T2
        {
            _NumberOfLegs = numberoflegs;
            _ColorOfTable = color;
            _Type = type;
        }
       
       

        
    }

    class Octagon
    {
        public double _Area;
        public double _Scoop;
        public Octagon(int high , int width)
        {
            _Area = GetArea(high, width);
            _Scoop = GetScoop(high, width);
        }
        public double GetArea(int high, int width) // חישוב שטח
        {
            return high * width;
        }
        public double GetScoop(int high , int width) // חישוב היקף
        {
            return (high * 2) +( width * 2);
        }
    }


    
}
