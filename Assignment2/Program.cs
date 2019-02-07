using System;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            // left rotation
            Console.WriteLine("Left Rotation");
            int d = 4;
            int[] a = { 1, 2, 3, 4, 5 };
            int[] r = rotLeft(a, d);
            displayArray(r);

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
            int[] arr2 = { 0, 1, 2, 4, 6, 5, 3 };
            Console.WriteLine(findMedian(arr2));

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
        }

        // Complete the rotLeft function below.
        static int[] rotLeft(int[] a, int d)
        {
            return new int[] { };
        }

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
                    for(int j=0; j<i;j++)
                    {
                        sum_l += arr1[j];
                    }
                    for(int k=i+1;k<arr1.Length;k++)
                    {
                        sum_r += arr1[k];
                    }
                    if(sum_l==sum_r)
                    {
                        balance_check = true;
                    }
                }
                if(balance_check==true)
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
        static int[] missingNumbers(int[] arr, int[] brr)
        {
            return new int[] { };
        }


        // Complete the gradingStudents function below.
        static int[] gradingStudents(int[] grades)
        {
            return new int[] { };
        }

        // Complete the findMedian function below.
        static int findMedian(int[] arr)
        {
            return 0;
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
