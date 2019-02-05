using System;
using System.Collections;
using System.Collections.Generic;

namespace DictionaryExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //DictionaryExamples1();
            DictionaryKeysShouldBeUniqueExamples1();
            Console.Read();
        }

        static void DictionaryExamples1()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            Dictionary<string, string> dict2 = new Dictionary<string, string>();

            dict.Add(1, "Computers");
            dict.Add(2, "Books");
            dict.Add(3, "Electronics");
            dict.Add(7, "Automative");
            dict.Add(8, "Something");

            string value = dict[2];
            Console.WriteLine(value);

            try
            {
                string value2 = dict[4];
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (dict.ContainsKey(3))
            {
                value = dict[3];
            }

            Console.WriteLine();
            Console.WriteLine("Do dict contains 3? {0}", dict.ContainsKey(3));
            Console.WriteLine("Do dict contains 5? {0}", dict.ContainsKey(5));
            Console.WriteLine("Do dict contains 7? {0}", dict.ContainsKey(7));
            Console.WriteLine("Do dict contains Electronics? {0}", dict.ContainsValue("Electronics"));

            Console.WriteLine();
            foreach (KeyValuePair<int, string> k in dict)
            {
                Console.Write(k.Key);
                Console.Write(" ");
                Console.WriteLine(k.Value);
            }
        }

        static void DictionaryKeysShouldBeUniqueExamples1()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            try
            {
                dict.Add(1, "Computers");
                dict.Add(2, "Books");
                dict.Add(3, "Electronics");
                dict.Add(2, "Automative");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }   
        }
    }
}
