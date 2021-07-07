using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memory_project
{
    class Program
    {
        static void Main(string[] args)
        {

            int Sizeofarray;

            Console.WriteLine("player 1 :");
            string player1 = Console.ReadLine();
            Console.WriteLine("player 2 :");
            string player2 = Console.ReadLine();
            int player1_points = 0;
            int player2_points = 0;

            string turn = player1;


            do
            {
                Console.WriteLine("Enter number of the size of array");
                Sizeofarray = int.Parse(Console.ReadLine());
            }
            while (Sizeofarray % 2 == 1 || Sizeofarray < 0 || Sizeofarray > 8);
            char[,] myarray = new char[Sizeofarray, Sizeofarray];
            int cards = Sizeofarray * Sizeofarray;
            int pair = cards / 2;
            Random run = new Random();
            int card1r;
            int card1c;
            int card2r;
            int card2c;

            for (int i = 1; i <= pair; i++)
            {
                char mychar = (char)run.Next(65, 90);
                int check = 0;
                while (check != 2)
                {
                    int column = run.Next(0, myarray.GetLength(1));
                    int row = run.Next(0, myarray.GetLength(0));
                    if (myarray[row, column] == '\0')
                    {
                        myarray[row, column] = mychar;
                        check++;
                    }
                }
            }
            int counterpoints = 0;
            while (counterpoints != pair)
            {
                WriteBord(myarray);
                do
                {
                    Console.WriteLine("{0} Enter card1 row", turn);
                    card1r = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} Enter card1 column", turn);
                    card1c = int.Parse(Console.ReadLine());

                }
                while (card1r <= 0 || card1r > myarray.GetLength(0) || card1c <= 0 || card1c > myarray.GetLength(1) || myarray[card1r - 1, card1c - 1] == (char)48);
                WriteBord2(myarray, card1r - 1, card1c - 1);
                do
                {
                    Console.WriteLine("{0} Enter card2 row", turn);
                    card2r = int.Parse(Console.ReadLine());
                    Console.WriteLine("{0} Enter card2 column", turn);
                    card2c = int.Parse(Console.ReadLine());
                }
                while (card2r > myarray.GetLength(0) || card2c > myarray.GetLength(1) || myarray[card2r - 1, card2c - 1] == (char)48 || card1c == card2c && card1r == card2r || card2r <= 0 || card2c <= 0);
                WriteBord3(myarray, card1r - 1, card1c - 1, card2r - 1, card2c - 1);
                char card1 = myarray[card1r - 1, card1c - 1];
                Console.WriteLine($"card1: {card1}");
                char card2 = myarray[card2r - 1, card2c - 1];
                Console.WriteLine($"card2: {card2}");
                if (card1 == card2)
                {
                    myarray[card1r - 1, card1c - 1] = (char)48;
                    myarray[card2r - 1, card2c - 1] = (char)48;
                    if (turn == player1)
                    {
                        player1_points++;

                    }
                    else
                    {
                        player2_points++;
                    }

                    counterpoints++;
                    continue;
                }
                if (turn == player1)
                {
                    turn = player2;
                }
                else
                {
                    turn = player1;
                }

                continue;

            }
            Console.WriteLine("{0} points : {1} {2} points :{3}", player1, player1_points, player2, player2_points);



        }
        public static void WriteBord(char[,] myarray)
        {

            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    if (myarray[i, j] == (char)48)
                    {
                        Console.Write(myarray[i, j] + "\t");

                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }

        }

        public static void WriteBord2(char[,] myarray, int row1, int column1)
        {
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    if (i == row1 && j == column1)
                    {
                        Console.Write(myarray[row1, column1] + "\t");
                    }
                    else if (myarray[i, j] == (char)48)
                    {
                        Console.Write("0" + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }

        }

        public static void WriteBord3(char[,] myarray, int row1, int column1, int row2, int column2)
        {
            for (int i = 0; i < myarray.GetLength(0); i++)
            {
                for (int j = 0; j < myarray.GetLength(1); j++)
                {
                    if (i == row1 && j == column1)
                    {
                        Console.Write(myarray[row1, column1] + "\t");
                    }
                    else if (i == row2 && j == column2)
                    {
                        Console.Write(myarray[row2, column2] + "\t");
                    }
                    else if (myarray[i, j] == (char)48)
                    {
                        Console.Write("0" + "\t");
                    }
                    else
                    {
                        Console.Write("X" + "\t");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}












