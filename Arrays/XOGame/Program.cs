using System;
using System.Collections;

namespace XOGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] nums = new char[3, 3] 
            { 
                { ' ', ' ', ' ' }, 
                { ' ', ' ', ' ' }, 
                { ' ', ' ', ' ' }
            };


            Console.WriteLine("Start game:");

            while (true)
            {
                string p = Console.ReadLine();
                string[] indexes = p.Split(',');
                int firstIndex = Convert.ToInt32(indexes[0]);
                int secondIndex = Convert.ToInt32(indexes[1]);
                nums[firstIndex, secondIndex] = player;
                CheckWin(nums, player);
                Board(nums);
                player = player == 'X' ? 'O' : 'X';
            }
        }

        static bool CheckDraw(char[,] arr)
        {
            foreach(char c in arr)
            {
                if(c == ' ')
                {
                    return false;
                }
            }

            return true;
        }

        static bool CheckWin(char[,] arr, char c)
        {
           for(int i = 0; i< arr.GetLength(0); i++)
            {
                char[] row = new char[3];
                char[] column = new char[3];
                for (int j = 0; j< arr.GetLength(1); j++)
                {
                    row[j] = arr[i, j];
                    column[j] = arr[j, i];
                    
                }

                bool win = true;
                foreach(char k in row)
                {
                    if(k != c)
                    {
                        win = false;
                    }
                }

                if (win)
                {
                    Console.WriteLine("You Won!");
                    return win;
                }

                win = true;
                foreach (char k in column)
                {
                    if (k != c)
                    {
                        win = false;
                    }
                }

                if (win)
                {
                    Console.WriteLine("You Won!");
                    return win;
                }
            }

            return false ;
        }

        private static void Board(char[,] arr)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[0, 0], arr[0, 1], arr[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1, 0], arr[1, 1], arr[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[2, 0], arr[2, 1], arr[2, 2]);
            Console.WriteLine("     |     |      ");
        }
    }
}