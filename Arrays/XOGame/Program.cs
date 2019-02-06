using System;
using System.Collections;

namespace XOGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char player = 'X';
            char[,] nums = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

            int numberOfMoves = 0;

            Console.WriteLine("Start game:");
            Board(nums);
            while (true)
            {

                Console.WriteLine(String.Format("Player {0} turn. Enter the coordinates on the board.", player));
                string p = Console.ReadLine();
                string[] indexes = p.Split(',');
                int firstIndex = Convert.ToInt32(indexes[0]);
                int secondIndex = Convert.ToInt32(indexes[1]);
                if (LegalMove(nums, firstIndex, secondIndex))
                {
                    nums[firstIndex, secondIndex] = player;
                    Board(nums);
                    player = player == 'X' ? 'O' : 'X';
                    numberOfMoves++;
                }
                if (CheckWin(nums))
                {
                    Board(nums);
                    break;
                }
                if (FullBoard(numberOfMoves))
                {
                    Console.WriteLine("Game over, it ended in draw");
                    break;
                }

            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
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

        private static bool FullBoard(int count)
        {
            if (count == 9) return true;
            return false;
        }

        private static bool CheckWin(char[,] arr)
        {
            char[] comparisonArray = new char[3];

            for (int i = 0; i < 3; i++)
            {
                // horizontal
                for (int j = 0; j < 3; j++)
                    comparisonArray[j] = arr[i, j];
                if (Array.TrueForAll(comparisonArray, x => x == comparisonArray[0] && x != ' '))
                {
                    Console.WriteLine(String.Format("Player {0} wins", comparisonArray[0]));
                    return true;
                }
                // vertical
                for (int j = 0; j < 3; j++)
                    comparisonArray[j] = arr[j, i];
                if (Array.TrueForAll(comparisonArray, x => x == comparisonArray[0] && x != ' '))
                {
                    Console.WriteLine(String.Format("Player {0} wins", comparisonArray[0]));
                    return true;
                }

            }
            // diagonal left top -> right bottom
            for (int i = 0; i < 3; i++)
                comparisonArray[i] = arr[i, i];
            if (Array.TrueForAll(comparisonArray, x => x == comparisonArray[0] && x != ' '))
            {
                Console.WriteLine(String.Format("Player {0} wins", comparisonArray[0]));
                return true;
            }
            // diagonal bottom right -> left top
            for (int i = 0; i < 3; i++)
            {
                for (int j = 2; j == 0; j--)
                {
                    comparisonArray[0] = arr[j, i];
                }
            }
            if (Array.TrueForAll(comparisonArray, x => x == comparisonArray[0] && x != ' '))
            {
                Console.WriteLine(String.Format("Player {0} wins", comparisonArray[0]));
                return true;
            }
            return false;

        }

        private static bool LegalMove(char[,] arr, int firstIndex, int secondIndex)
        {
            if (arr[firstIndex, secondIndex] != ' ')
            {
                Console.WriteLine("Illegal move try again");
                Board(arr);
                return false;
            }
            return true;
        }
    }
}