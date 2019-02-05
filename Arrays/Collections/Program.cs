using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListExamples();
            //ListExamples2();
            string animal = "Giraffe";
            // effariG
            Stack st = new Stack();
            foreach(char c in animal)
            {
                st.Push(c);
            }

            foreach(char c in st)
            {
                Console.Write(c);
            }

            //StackExamples();
            //QueueExamples();
            Console.Read();
        }

        static void ListExamples()
        {
            // Create an array list.
            ArrayList al = new ArrayList();
            Console.WriteLine("Initial number of elements: " + al.Count);
            Console.WriteLine();
            Console.WriteLine("Adding 6 elements");
            // Add elements to the array list
            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('B');
            al.Add('D');
            al.Add('F');
            Console.WriteLine("Number of elements: " +
            al.Count);
            // Display the array list using array indexing.
            Console.Write("Current contents: ");
            for (int i = 0; i < al.Count; i++)
                Console.Write(al[i] + " ");

            Console.WriteLine();
            Console.Write("Repeat ");
            foreach (char c in al)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Removing 2 elements");
            // Remove elements from the array list.
            al.Remove('F');
            al.Remove('A');

            Console.WriteLine("Number of elements: " + al.Count);
            // Use foreach loop to display the list.
            Console.Write("Contents: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine("\n");
            Console.WriteLine("Adding 20 more elements");
            // Add enough elements to force al to grow.
            for (int i = 0; i < 20; i++)
                al.Add((char)('a' + i));
            Console.WriteLine("Current capacity: " +
            al.Capacity);
            Console.WriteLine("Number of elements after adding 20: " +
            al.Count);
            Console.Write("Contents: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine("\n");
            // Change contents using array indexing.
            Console.WriteLine("Change first three elements");
            al[0] = 'X';
            al[1] = 'Y';
            al[2] = 'Z';
            Console.Write("Contents: ");
            foreach (char c in al)
                Console.Write(c + " ");
            Console.WriteLine();
        }

        static void ListExamples2()
        {
            ArrayList al = new ArrayList();
            // Add elements to the array list.
            al.Add(1);
            al.Add(2);
            al.Add(3);
            al.Add(4);
            Console.Write("Contents: ");
            foreach (int i in al)
                Console.Write(i + " ");
            Console.WriteLine();
            // Get the array.
            int[] ia = (int[])al.ToArray(typeof(int));
            int sum = 0;
            // Sum the array.
            for (int i = 0; i < ia.Length; i++)
                sum += ia[i];
            Console.WriteLine("Sum is: " + sum);
        }

        static void QueueExamples()
        {
            Queue q = new Queue();
            foreach (int i in q)
                Console.Write(i + " ");
            Console.WriteLine();
            ShowEnq(q, 22);
            ShowEnq(q, 65);
            ShowEnq(q, 91);
            ShowDeq(q);
            ShowDeq(q);
            ShowDeq(q);
            try
            {
                ShowDeq(q);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Queue empty.");
            }
        }

        static void StackExamples()
        {
            Stack st = new Stack();
            foreach (int i in st)
                Console.Write(i + " ");
            Console.WriteLine();
            ShowPush(st, 22);
            ShowPush(st, 65);
            ShowPush(st, 91);
            ShowPop(st);
            ShowPop(st);
            ShowPop(st);

            try
            {
                ShowPop(st);
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Stack empty.");
            }

        }

        static void ShowPush(Stack st, int a)
        {
            st.Push(a);
            Console.WriteLine("Push(" + a + ")");
            Console.Write("stack: ");
            foreach (int i in st)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void ShowPop(Stack st)
        {
            Console.Write("Pop -> ");
            int a = (int)st.Pop();
            Console.WriteLine(a);
            Console.Write("stack: ");
            foreach (int i in st)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void ShowEnq(Queue q, int a)
        {
            q.Enqueue(a);
            Console.WriteLine("Enqueue(" + a + ")");
            Console.Write("queue: ");
            foreach (int i in q)
                Console.Write(i + " ");
            Console.WriteLine();
        }

        static void ShowDeq(Queue q)
        {
            Console.Write("Dequeue -> ");
            int a = (int)q.Dequeue();
            Console.WriteLine(a);
            Console.Write("queue: ");
            foreach (int i in q)
                Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}