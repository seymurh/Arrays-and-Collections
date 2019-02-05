using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime k;
            string l = string.Empty;

            l = "asdf";

            k = new DateTime();
            Console.WriteLine(k);
            string a = "neural";
            string b = "unreal";
            char[] aChars = a.ToCharArray();
            char[] bChars = b.ToCharArray();
            Array.Sort(bChars);
            Array.Sort(aChars);

            bool result = aChars.SequenceEqual(bChars);
            //// Declare a single-dimensional array 
            //int[] array1 = new int[5];


            //int[] array = new int[3] { 1, 3, 5 };


            //int[] arr = new int[3];
            //arr[0] = 1;
            //arr[1] = 3;
            //arr[2] = 5;

            //// Declare and set array element values
            //int[] array2 = new int[] { 1, 8, 6, 7, 9 };

            //string[] fruits = new string[] { "apple", "banana", "kiwi", "orange" };

            //// Alternative syntax
            //int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //// Declare a two dimensional array
            //int[,] multiDimensionalArray1 = new int[2, 3];

            //// Declare and set array element values
            //int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            ////ArrayOperations();

            ////Console.WriteLine(multiDimensionalArray1.Rank);

            ////ArrayMethods();
            //ArrayMethods2();
            Console.Read();

        }

        static void ArrayOperations()
        {
            string[] fruits = new string[4] { "apple", "banana", "kiwi", "orange" };

            string firstFruit = fruits[0];
            string lastFruit = fruits[fruits.Length - 1];
            string secondFruit = fruits[1];

            Console.WriteLine($"Array length is {fruits.Length}");
            Console.WriteLine($"First fruit: {firstFruit}");
            Console.WriteLine($"Last fruit: {lastFruit}");
            Console.WriteLine($"Second Fruit: {secondFruit}");
            fruits[1] = "strawberry";
            secondFruit = fruits[1];
            Console.WriteLine($"Second fruit changed to: {secondFruit}");
        }

        static void ArrayMethods()
        {
            int[] numbers = new int[] { 3, 2, 8, 5 };
            Console.WriteLine("Original array: {0}", string.Join(',', numbers));
            Array.Sort(numbers);
            Console.WriteLine("Sorted array: {0}", string.Join(',', numbers));

            string[] fruits = new string[4] { "banana", "apple", "orange", "kiwi" };
            Array.Sort(fruits);
            Console.WriteLine("Sorted fruits: {0}", string.Join(',', fruits));


            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1, 2, 3 };
            Console.WriteLine("arr1 == arr2: {0}", arr1 == arr2);
            Console.WriteLine("arr1.SequenceEqual(arr2): {0}", arr1.SequenceEqual(arr2));

            string[] cars = { "BMW", "Audi", "Ford", "Volvo" };
            int k = Array.IndexOf(cars, "Audi");
            Console.WriteLine($"Index of Audi is {k}");
            k = Array.IndexOf(cars, "Dodge");
            Console.WriteLine($"Index of Dodge is {k}");
        }

        static void ArrayMethods2()
        {
            string[] fruits = new string[4] { "banana", "apple", "orange", "kiwi" };

            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            string car = "Audi";

            foreach(char c in car)
            {
                Console.WriteLine(c);
            }

            char[] arr = car.ToCharArray();
        }

        static void StringAsArray()
        {
            string book = "Harry Potter";
            char c = book[0];
            Console.WriteLine(c);

        }
    }
}