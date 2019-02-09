using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;

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
            //Maximum Toys
            Console.WriteLine("\n\nMaximum toys");
            Console.WriteLine("\nEnter budget for toys:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter a list of prices:");
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            Console.WriteLine(maximumToys(prices, k));
            Console.ReadLine();

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums");
            List<int> arr = new List<int> { 1, 2, 3 };
            Console.WriteLine(balancedSums(arr));

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
            Console.WriteLine("Enter size of array");
            Console.ReadLine();
            Console.WriteLine("Enter the space separated elements of the array");
            string[] comps = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(comps, int.Parse);
            int[] sortarr = BubbleSort(arr, arr.Length);
            ClosestNumbers(sortarr);
            Console.ReadLine();


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
                try
                {
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
                    return 0;
                }
                catch
                {
                    Console.WriteLine("Exception occured while computing maximumToys()");
                    return 0;
                }
            }

            // Complete the balancedSums function below.
            static string balancedSums(List<int> arr)
        {
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
            static int[] ClosestNumbers(int[] sortarr)
            {
                try
                {
                    int diff = Math.Abs(sortarr[1] - sortarr[0]);
                    ArrayList results = new ArrayList();
                    results.Add(sortarr[0] + " " + sortarr[1]);
                    int index;
                    for (index = 1; index < sortarr.Length - 1; index++)
                    {
                        int tmp = Math.Abs(sortarr[index + 1] - sortarr[index]);
                        if (tmp < diff)
                        {
                            diff = tmp;
                            results.Clear();
                            results.Add(sortarr[index] + " " + sortarr[index + 1]);
                        }
                        else if (tmp == diff)
                        {
                            results.Add(sortarr[index] + " " + sortarr[index + 1]);
                            index++;
                        }
                    }
                    Console.WriteLine(String.Join(" ", results.ToArray()));
                }
                catch
                {
                    Console.WriteLine("Exception Occured! Enter array in correct format.");
                    Console.ReadLine();
                }
                int[] t = new int[0];
                return t;
            }
            static int[] BubbleSort(int[] temparr, int n)
            {
                int temp;
                for (int j = 0; j <= n - 2; j++)
                {
                    for (int i = 0; i <= n - 2; i++)
                    {
                        if (temparr[i] > temparr[i + 1])
                        {
                            temp = temparr[i + 1];
                            temparr[i + 1] = temparr[i];
                            temparr[i] = temp;
                        }
                    }
                }
                return temparr;
            }
        }


        // Complete the dayOfProgrammer function below.
        static string dayOfProgrammer(int year)
        {
            return "";
        }
    }
}
