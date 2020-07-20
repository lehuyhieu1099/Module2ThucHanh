using System;

namespace Searching_and_Sort
{
    class Program
    {
        public static int[] arr;
        static void Main(string[] args)
        {
            while (true)
            {
                ShowMenu();
            }
        }
        public static MyArray array = new MyArray();
        public static void ShowMenu()
        {
            string choice;
            Console.WriteLine("Menu");
            Console.WriteLine("1. Create Array");
            Console.WriteLine("2. IsSymmetryArray?");
            Console.WriteLine("3. Sort");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Enter your choice: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Create Array:");
                    Console.WriteLine("How many elements do you want? : ");
                    int size = int.Parse(Console.ReadLine());
                    arr = array.CrerateArray(size);
                    array.PrintArr(arr);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.WriteLine("IsSymmetryArray?:");
                    Console.WriteLine(array.IsSymmetryArray(arr));
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Sort");
                    array.PrintArr(arr);
                    Console.WriteLine();
                    Console.WriteLine("Array after sort is: ");
                    array.ArrSort(arr);
                    array.PrintArr(arr);
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("Search:");                  
                    array.PrintArr(arr);
                    Console.WriteLine();
                    Console.WriteLine("Enter number to find: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{number} at {array.Find(arr, number)}");
                    Console.WriteLine();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
