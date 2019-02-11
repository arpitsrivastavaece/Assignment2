using System;
using System.Collections;
using System.Collections.Generic;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotate Left
            Console.WriteLine("Rotate Left\n");
            int[] a = new int[10]; int d = 0;
            rotleft(a, d);
            Console.ReadKey();

            // Maximum toys
            Console.WriteLine("\n\nMaximum toys");
            Console.WriteLine("\nEnter budget for toys:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter a list of prices separated by single spaces:");
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            Console.WriteLine("\nMaximum number of toys that can be bought: {0}",maximumToys(prices, k));
            Console.ReadLine();

            // Balanced sums
            Console.WriteLine("\n\nBalanced sums\n");
            List<int> arr1 = new List<int> { 1, 2, 3, 3 };
            int[] list_arr = arr1.ToArray();
            Console.Write("Is array ");
            displayArray(list_arr);
            Console.Write("\nBalanced?  ");
            Console.WriteLine(balancedSums(arr1));
            Console.ReadLine();

            // Missing numbers
            Console.WriteLine("\n\nMissing numbers\nEnter first array seperated by spaces: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine("Enter second array sepeated by single spaces: ");
            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));
            Console.WriteLine("The missing numbers in the first array are:{{0}}",missingNumbers(arr, brr));
           
            // grading students
            Console.WriteLine("\n\nGrading students");
            int[] grades = { 73, 67, 38, 33 };
            int[] r3 = gradingStudents(grades);
            displayArray(r3);

            // find the median
            Console.WriteLine("\n\nFind the median");
            int[] med = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("The median is {0}",median(med));
            Console.ReadKey();

            // closest numbers
            Console.WriteLine("\n\nClosest numbers");
            Console.WriteLine("Enter size of array");
            Console.ReadLine();
            Console.WriteLine("Enter the space separated elements of the array");
            string[] comps = Console.ReadLine().Split(' ');
            int[] arr_closest = Array.ConvertAll(comps, int.Parse);
            int[] sortarr = BubbleSort(arr_closest);
            ClosestNumbers(sortarr);
            Console.ReadLine();


            // Day of programmer
            Console.WriteLine("\n\nDay of Programmer\nEnter the year: ");
            int year = Int32.Parse(Console.ReadLine());
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

        // rotLeft function
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
            Console.Write("Array after {0} rotations: ", d);
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

        // maximumToys function
        static int maximumToys(int[] toys, int budget)
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
                        break;
                    }
                    else
                    {
                        maxToys++;
                    }
                }
                return maxToys;
            }
            catch
            {
                Console.WriteLine("Exception occured while computing maximumToys()");
                return 0;
            }
        }

        // balancedSums function
        static string balancedSums(List<int> arr1)
        {
            try
            {
                int[] arr2= arr1.ToArray();
                bool balance_check = false;
                for (int i = 0; i < arr2.Length; i++)
                {
                    int sum_l = 0;
                    int sum_r = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum_l += arr2[j];
                    }
                    for (int k = i + 1; k < arr2.Length; k++)
                    {
                        sum_r += arr2[k];
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
                Console.WriteLine("Exception Occurred!");
            }
            return "";
        }

        // missingNumbers function
        static int[] missingNumbers(int[] ar1, int[] ar2)
        {
            try
            {
                int[] aHist = new int[100];//Problem statement informs us that there are only 100 different values
                int[] bHist = new int[100];
                int min = int.MaxValue;

                foreach (int i in ar2) //Iterate ar1 to find the smalles value
                {
                    if (i < min)
                    {
                        min = i;
                    }
                }
                foreach (int i in ar2)//Iterate ar2 to find frequency of smallest value and store at index 0
                {
                    bHist[i - min]++;
                }
                foreach (int i in ar1)//Iterate ar1 to find frequency of smallest value and store at index 0
                {
                    aHist[i - min]++;
                }
                for (int i = 0; i < 100; i++)//Iterate frequency array and print the number obtained by
                                               //adding current index to minimum value
                {
                    if (aHist[i] < bHist[i])
                    {
                        Console.Write("{0} ", i + min);
                    }
                }
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Exception occurred!");
            }
            return new int[] { };
        }

        // gradingStudents function
        static int[] gradingStudents(int[] grades)
        { 
            // This method takes returns an array with updated grades as per the guidelines mentioned in the problem.

            try
            {
                int[] updated = new int[grades.Length];// New array to store updated values
                bool cont = true;// To check whether grades∈[0,100]
                for (int k = 0; k < updated.Length; k++)
                {
                    if (grades[k] < 0 || grades[k] > 100)
                    {
                        cont = false;
                    }
                }
                if (cont == true)// range ∈ [0,100]
                {
                    for (int i = 0; i < grades.Length; i++)
                    {
                        if (grades[i] > 37)//maximum limit to convert to passing grade
                        {
                            int quo = grades[i] / 5;// Quotient after dividing by 5(for approximation)
                            int high_num = (quo + 1) * 5;// The next multiple of 5
                                                         //Approximation
                            if (high_num - grades[i] < 3)
                            {
                                updated[i] = high_num;
                            }
                            else
                            {
                                updated[i] = grades[i];
                            }
                        }
                        else// grade<37
                        {
                            updated[i] = grades[i];
                        }
                    }
                }
                else// if even one grade is out of range
                {
                    throw new Exception();// Exception thrown
                }

                return updated;// Updated values are returned

            }


            catch
            {
                Console.WriteLine("Grades have to be between(and including) 0 and 100");//Exception
            }
            return new int[] { };
        }


        // findMedian function
        static float median(int[] a)
        {
            int[] new_arr = BubbleSort(a);//Sorted array
            int median_arr;// median of the array
            if(new_arr.Length%2!=0)// median principle for odd length while taking into consideration that array indexing starts form 0
            {
                median_arr = new_arr[(new_arr.Length - 1) / 2];
            }
            else// median principle for even length while taking into consideration that array indexing starts from 0
            {
                median_arr = new_arr[((new_arr[(new_arr.Length - 2) / 2]) + (new_arr[new_arr.Length / 2])) / 2];
            }
            return median_arr;// returns median
        }


        // closestNumbers function
        static int[] ClosestNumbers(int[] sortarr)
        {
            try
            {
                int diff = Math.Abs(sortarr[1] - sortarr[0]);
                ArrayList results = new ArrayList();//Set up a list which will contain the list of numbers having minimum difference
                results.Add(sortarr[0] + " " + sortarr[1]);
                int index;
                for (index = 1; index < sortarr.Length - 1; index++)
                {
                    int tmp = Math.Abs(sortarr[index + 1] - sortarr[index]);//Tracking min difference between any
                                                                            //two adjacent elements of the array
                    if (tmp < diff)
                    {
                        diff = tmp;//If difference of current element and next element is less than min clear the list
                        results.Clear();
                        results.Add(sortarr[index] + " " + sortarr[index + 1]);
                    }
                    else if (tmp == diff)//If difference is equal to min add both elements to results array
                    {
                        results.Add(sortarr[index] + " " + sortarr[index + 1]);
                        index++;
                    }
                }
                Console.WriteLine(String.Join(" ", results.ToArray()));//Display the elements of results array
            }
            catch
            {
                Console.WriteLine("Exception Occured!");
                Console.ReadLine();
            }
            int[] t = new int[0];
            return t;
        }


        // Day of the programmer function
        static string dayOfProgrammer(int year)
        {
            try
            {
                int day = 13;// for a regular year the day of the programmer is on 12.09.yyyy

                // Since the day for regular year has already been set, only day change in leap year is required

                if (year < 2701 && year > 1699)// If year is out of this range, exception is thrown
                {
                    if (year <= 1917)//Julian Calender System
                    {
                        if (year % 4 == 0)// Julian leap year
                        {
                            day -= 1;// To take one extra day in feb into consideration
                        }
                    }
                    else if (year == 1918)//The year where transition was compensated by reducing 13 days in feb
                    {
                        day += 13;// To take 13 less days into consideration
                    }
                    else// Gregorian Calender System
                    {
                        if ((year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0)))// Gregorian principle for leap year
                        {
                            day -= 1;
                        }
                    }
                    return day + ".09." + year;

                }
                else// If the year is out of time machine's range, exception is thrown
                {
                    throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Year does not belong to [1700,2700]");
            }

            return "";
        }

        // Bubble Sort method for sorting the array
        static int[] BubbleSort(int[] temparr)
        {
            int temp;
            int n = temparr.Length;
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
}
