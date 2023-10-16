using System.Collections.Generic;
using System.Text;
using Utility;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My LinkedList 1\n");

            MyLinkedList<int> list = new MyLinkedList<int>();

            //Add() **************************************************************
            list.Add(100);
            list.Add(2);
            list.Add(300);
            list.Add(4);
            list.Add(5);

            //ToClonedArray() **************************************************************
            Console.WriteLine("ToClonedArray:");
            var arr1 = list.ToClonedArray();

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }


            //ToArray() **************************************************************
            Console.WriteLine();
            Console.WriteLine("ToArray:");
            var arr2 = list.ToArray();

            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }



            //IndexOf() **************************************************************
            Console.WriteLine("\nIndexOf:");
            Console.WriteLine("IndexOf 100: " + list.IndexOf(100));
            Console.WriteLine("IndexOf 2: " + list.IndexOf(2));
            Console.WriteLine("IndexOf 300: " + list.IndexOf(300));
            Console.WriteLine("IndexOf 4: " + list.IndexOf(4));
            Console.WriteLine("IndexOf 5: " + list.IndexOf(5));




            //RemoveByIndex() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("RemoveByIndex:");
            //list.RemoveByIndex(3);
            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}




            //Remove() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("Remove:");
            //list.Remove(100);
            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}



            //RemoveAfter() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("RemoveAfter 300:");
            //list.RemoveAfter(300);
            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}




            //RemoveAllAfter() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("RemoveAllAfter 300:");
            //list.RemoveAllAfter(300);
            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //RemoveFirst() and RemoveLast() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("RemoveFirst and RemoveLast:");
            //list.RemoveFirst();
            //list.RemoveLast();
            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //Clear() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("Clear:");
            //list.Clear();

            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}



            //Contains() **************************************************************
            Console.WriteLine();
            Console.WriteLine("Contains 300: " + list.Contains(300));




            //GetValue() **************************************************************
            Console.WriteLine();
            Console.WriteLine("GetValue index 0: " + list.GetValue(0));




            //Sort() **************************************************************
            //Console.WriteLine();
            //Console.WriteLine("Sort():");
            //list.Sort();

            //var arr = list.ToClonedArray();

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}


            //Foreach loop **************************************************************
            Console.WriteLine();
            Console.WriteLine("Foreach loop:");
            //list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            //For loop (index) **************************************************************
            Console.WriteLine();
            Console.WriteLine("For loop (index):");
            //list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            // First and last**************************************************************
            Console.WriteLine();
            Console.WriteLine("First : " + list.First);
            Console.WriteLine("Last : "+ list.Last);



            // MyLinkedList<String> **************************************************************
            Console.WriteLine();
            Console.WriteLine("MyLinkedList<String> :");
            MyLinkedList<String> strings = new MyLinkedList<String>();

            strings.Add("b");
            strings.Add("d");
            strings.Add("a");
            strings.Add("c");
            strings.Sort();
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }











            Console.ReadKey();
        }
    }
}



