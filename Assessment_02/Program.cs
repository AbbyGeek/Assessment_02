using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int FinalGrade = 100;
                    Console.WriteLine("1) To The Max! \n2) Odd One Out \n3) List on List on List \n4) The Second Dimension");
                    Console.Write("Enter the problem number you wish to assess: ");
                    int testNum = int.Parse(Console.ReadLine());

                    if (testNum == 1)
                    {
                        Max();
                    }
                    if (testNum == 2)
                    {
                        Odd();
                    }
                    if (testNum == 3)
                    {
                        ListOnList();
                    }
                    if (testNum == 4)
                    {
                        SecondDimension();
                    }
                }
                catch
                {
                    Console.WriteLine("You did not imput a correct value. Try again \n \n");
                    continue;
                }
            }

        }
        public static void Max()
        {

            Console.Write("You need to create an array. Please enter the length of the array you want to make: ");

            int len = int.Parse(Console.ReadLine());
            int[] arr = new int[len];
            Console.WriteLine("Enter items for the array ");
            for (int i = 0; i < len; i++)
            {
                try
                { 
                    arr[i] = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Item is not a number. Re-enter this item.");
                    i = i - 1;
                    continue;
                }
            }
            Console.WriteLine($"The maximum value that you entered is: {arr.Max()} \n");

        }
        public static void Odd()
        {
            Console.Write("Enter a number: ");
    
            double num = double.Parse(Console.ReadLine());
            double len = Math.Ceiling(num / 2);
            int[] arr = new int[Convert.ToInt32(len)];
            int index = 0;
            int sum = 0;
            for (int i = 1; i <= num; i += 2)
            {
                arr[index] = i;
                sum += i;
            }
            Console.WriteLine($"The sum of all odd numbers between 1 and {num} is: {sumMeth(sum)}");
            Console.WriteLine($"The average of all odd numbers between 1 and {num} is: {avgMeth(arr, sum)}");
            
            
            


        }
        public static void ListOnList()
        {
            
            List<string> list = new List<string> { "Red", "Blue", "Yellow", "Green", "Purple", "Orange"};
            Console.WriteLine("You have a list of colors. The 6 primary and secondary colors. You may.....");
            while (true)
            {
                Console.WriteLine("1) Add item to list \n2) Search The List \n3) Sort the list alphabetically and print to screen \n4) quit \nPlease select one of the options above");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    add(list);
                }
                if (choice == 2)
                {
                    search(list);
                    
                }
                if (choice == 3)
                {
                    list.Sort();
                    printList(list);
                }

                if (choice == 4)
                {
                    return;
                }

            }

        }
        public static void SecondDimension()
        {
            int[,] arr = new int[,] { {5,-4,3,0}, {5,1,-2,-1}, {8,6,-7,4}, {-2,1,-5,2} };
            Num4Ans(arr);
            


        }
        public static string sumMeth(int sum)
        {
            return sum.ToString();
        }
        public static string avgMeth(int[] arr, int sum)
        {
            int len = arr.Length;
            return Convert.ToDecimal(sum / len).ToString();
        }
        public static void add(List<string> list)
        {
            Console.Write("Enter item to add to list:");
            list.Add(Console.ReadLine());
        }
        public static void search(List<string> list)
        {
            Console.Write("Enter search phrase:");
            string search = Console.ReadLine();
            int count = 0;
            foreach (string x in list)
            {
                if (x.Contains(search))
                {
                    Console.WriteLine(x);
                    count += 1;
                }
            }
            Console.WriteLine($"{count} item(s) include your search phrase \n");
        }
        public static void printList(List<string> list)
        {
            foreach (string x in list) { Console.WriteLine(x); }
        }
        public static void Num4Ans(int[,] arr)
        {
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                sum += arr[i, i];
            }
            Console.WriteLine(sum);

        }
        
    }
}

