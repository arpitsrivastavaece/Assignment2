using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotate Left
            int[] a = new int[10]; int d = 0;
            rotleft(a, d);
            Console.ReadKey();//rotate left

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            //Get Budget for toys
            int a, k, ToyCount;
            Console.WriteLine("Enter budget for buying toys:");
            k = Convert.ToInt32(Console.ReadLine());
            //Get Count of toys
            Console.WriteLine("Enter the count of toys available:");
            ToyCount = Convert.ToInt32(Console.ReadLine());
            if (ToyCount > 1)
            //Get prices for Toys
            {
                int[] prices = new int[ToyCount];
                Console.WriteLine("Enter a list of prices:");
                for (a = 0; a < ToyCount; a++)
                {
                    Console.Write("element - {0} : ", a);
                    prices[a] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(maximumToys(prices, k));
            }
            else
            {
                if (ToyCount == 1)
                {
                    int single = 0;
                    Console.WriteLine("Enter price of toy:");
                    single = Convert.ToInt32(Console.ReadLine());
                    if (k >= single)
                    {
                        Console.WriteLine("The available toy can be purchased:");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Budget is less than the price of toy");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("No toys available for purchase");
                    Console.ReadKey();
                }
            }


            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));
            Console.ReadLine();

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers");
            int[] arr1 = { 203, 204, 205, 206, 207, 208, 203, 204, 205, 206 };
            int[] brr = { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };
            int[] r2 = missingNumbers(arr1, brr);
            displayArray(r2);

            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] a = new int[10];
            median(a);
            Console.ReadKey();

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            int[] arr3 = { 5, 4, 3, 2 };
            int[] r4 = closestNumbers(arr3);
            displayArray(r4);

            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer");
            int year = 2017;
            Console.WriteLine(dayOfProgrammer(year));
        }

        static void displayArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
            {
                Console.Write(n + " ");
            }
        }*/

        // Complete the rotLeft function below.
        static void rotleft(int[] a, int d)
        {
            int i, n;
            a = new int[10];
            Console.WriteLine("Enter the size of array");
            string inp = Console.ReadLine();
            n = Convert.ToInt32(inp);
            Console.WriteLine("Enter the array");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0}-", i);

                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine("\nEnter the number of rotations");
            string userinp = Console.ReadLine();
            d = Convert.ToInt32(userinp);
            for (i = 0; i < d; i++)
            {
                rotate(a, n);
            }
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

        static void rotate(int[] a, int n)
        {
            int i, temp;
            temp = a[0];
            for (i = 0; i < n - 1; i++)
            {
                a[i] = a[i + 1];
            }
            a[i] = temp;
        }//rotate left




        // Complete the maximumToys function below.
        int maximumToys(int[] toys, int budget)
        {
            //Sorting the prices array in ascending order using Bubble sort
            int maxToys = 0;
            int temp = 0;
            for (int j = 0; j <= toys.Length - 2; j++)
            {
                for (int i = 0; i <= toys.Length - 2; i++)
                {
                    if (toys[i] > toys[i + 1])
                    {
                        temp = toys[i + 1];
                        toys[i + 1] = toys[i];
                        toys[i] = temp;
                    }
                }
            }
            //foreach (int p in toys)
            //Console.Write(p + " ");

            //Comparing the sorted array with Mark's budget to find the maximum number of toys
            for (int count = 0; count < toys.Length; count++)
            {
                budget = budget - toys[count];

                if (budget < 0)
                {
                    Console.WriteLine("\n\nMaximum number of toys that can be bought: " + maxToys);
                    break;

                }
                else
                {
                    maxToys++;
                }
            }
            Console.ReadKey();
            return 0;
        }
    }


    // Complete the balancedSums function below.
    static string balancedSums(List<int> arr)
    {
        try
        {
            int[] arr1 = arr.ToArray();
            bool balance_check = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                int sum_l = 0;
                int sum_r = 0;
                for (int j = 0; j < i; j++)
                {
                    sum_l += arr1[j];
                }
                for (int k = i + 1; k < arr1.Length; k++)
                {
                    sum_r += arr1[k];
                }
                if (sum_l == sum_r)
                {
                    balance_check = true;
                }
            }
            if (balance_check == true)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }
        catch
        {
            Console.WriteLine("Exception Occured!");
        }
        return "";
    }

    // Complete the missingNumbers function below.
    static int[] missingNumbers(int[] arr)
    {

    }


    // Complete the gradingStudents function below.
    static int[] gradingStudents(int[] grades)
    {
        try
        {
            int[] brr = new int[grades.Length];
            bool cont = true;
            for (int k = 0; k < brr.Length; k++)
            {
                if (grades[k] < 0 || arr[k] > 100)
                {
                    cont = false;
                }
            }
            if (cont == true)
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    if (grades[i] > 37)
                    {
                        int quo = grades[i] / 5;
                        int high_num = (quo + 1) * 5;
                        if (high_num - grades[i] < 3)
                        {
                            brr[i] = high_num;
                        }
                        else
                        {
                            brr[i] = grades[i];
                        }
                    }
                    else
                    {
                        brr[i] = arr[i];
                    }
                }
            }
            else
            {
                throw new Exception();
            }

            return brr;

        }

        catch
        {
            Console.WriteLine("Grades have to be between(and including) 0 and 100");
        }
        return new int[] { };
    }


    // Complete the findMedian function below.
    static void median(int[] a)
    {
        sorting(a);
    }

    static void sorting(int[] a)
    {
        a = new int[10];
        int i, n, temp, j;
        a = new int[10];
        Console.WriteLine("Enter the size of array");
        string inp = Console.ReadLine();
        n = Convert.ToInt32(inp);
        Console.WriteLine("Enter the array");
        for (i = 0; i < n; i++)
        {
            Console.Write("Element {0}-", i);

            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The array elements are:");
        for (i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine("\nThe sorted array elements are");
        for (i = 0; i < n; i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (a[i] > a[j])
                {
                    temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            Console.Write(a[i]);
        }
    }

    // Complete the closestNumbers function below.
    static int[] closestNumbers(int[] arr)
        {
            return new int[] { };
        }

        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            return "";
        }
    }
}
