using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment2_S19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // test of BubbleSort()
            int[] test = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
            displayArray(BubbleSort(test));
            Console.ReadLine();
            */

            //Rotate Left
            Console.WriteLine("___________________________");
            Console.WriteLine("Rotate Left");
            Console.WriteLine("___________________________\n");
            int[] a = new int[10]; int d = 0;
            displayArray(rotleft(a, d));
            Console.ReadLine();

            // Maximum toys
            Console.WriteLine("___________________________");
            Console.WriteLine("Maximum toys");
            Console.WriteLine("___________________________");
            Console.WriteLine("\nEnter budget for toys:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter a list of prices separated by single spaces: ");
            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));
            Console.WriteLine("\nMaximum number of toys that can be bought: {0}",maximumToys(prices, k));
            Console.ReadLine();

            // Balanced sums
            Console.WriteLine("___________________________");
            Console.WriteLine("Balanced sums");
            Console.WriteLine("___________________________");
            Console.WriteLine("\nEnter a array with elements separated by single spaces: ");
            int[] list_arr = Array.ConvertAll(Console.ReadLine().Split(' '), list_arrTemp => Convert.ToInt32(list_arrTemp));
            Console.Write("\nBalanced?  ");
            Console.WriteLine(balancedSums(list_arr));
            Console.ReadLine();

            // Missing numbers
            Console.WriteLine("___________________________");
            Console.WriteLine("Missing numbers\n___________________________\nEnter first array separated by single spaces: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            Console.WriteLine("\nEnter second array separated by single spaces: ");
            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp));
            Console.Write("The missing numbers are: ");
            missingNumbers(arr, brr);
            Console.ReadLine();

            // grading students
            Console.WriteLine("___________________________");
            Console.WriteLine("Grading students");
            Console.WriteLine("___________________________");
            Console.WriteLine("Enter grades separated by single spaces: ");
            int[] grades = Array.ConvertAll(Console.ReadLine().Split(' '), gradesTemp => Convert.ToInt32(gradesTemp));
            int[] r3 = gradingStudents(grades);
            Console.Write("The converted grades are: ");
            displayArray(r3);
            Console.ReadLine();

            // find the median
            Console.WriteLine("___________________________");
            Console.WriteLine("Find the median");
            Console.WriteLine("___________________________");
            Console.WriteLine("Enter elements of the array (with odd number of elements) separated by single spaces: ");
            int[] med = Array.ConvertAll(Console.ReadLine().Split(' '), medTemp => Convert.ToInt32(medTemp));
            Console.WriteLine("The median is {0}",findmedian(med));
            Console.ReadLine();

            // closest numbers
            Console.WriteLine("___________________________");
            Console.WriteLine("Closest numbers");
            Console.WriteLine("___________________________");
            Console.WriteLine("Enter the elements of the array separated by single spaces: ");
            int[] arr_closest = Array.ConvertAll(Console.ReadLine().Split(' '), arr_closestTemp => Convert.ToInt32(arr_closestTemp));
            ClosestNumbers(arr_closest);
            Console.ReadLine();


            // Day of programmer
            Console.WriteLine("___________________________");
            Console.WriteLine("Day of Programmer\n___________________________\nEnter the year: ");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The day of Programmer: {0}",dayOfProgrammer(year));
            Console.ReadLine();
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
        static int[] rotleft(int[] a, int d)
        {
            int i, n;
            int[] a1 = new int[a.Length];
            a = new int[10];
            Console.WriteLine("Enter the size of array");
            string inp = Console.ReadLine(); //input array with size 
            n = Convert.ToInt32(inp);
            Console.WriteLine("Enter the array");
            for (i = 0; i < n; i++)
            {
                Console.Write("Element {0}-", i);// one element at a time 

                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The array elements are:");
            for (i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");// print entered array
            }
            Console.WriteLine("\nEnter the number of rotations");
            string userinp = Console.ReadLine();
            d = Convert.ToInt32(userinp);//input rotations
            for (i = 0; i < d; i++)
            {
                rotate(a, n);// calling the rotate function
            }
            Console.Write("Array after {0} rotations: ", d);
            List<int> arraylist = new List<int>();
            foreach(int k in a)
            {
                if(k!=0)
                {
                    arraylist.Add(k);
                }
            }
            int[] new_a = arraylist.ToArray();
            return new_a;
        }// leftrotate

        static int[] rotate(int[] a, int n)
        {
            int i, temp;
            temp = a[0];
            for (i = 0; i < n - 1; i++)
            {
                a[i] = a[i + 1];//formula for putting next element in the first place
            }
            a[i] = temp;
            return a;
        }//rotate
        //Left Rotate

        // maximumToys function
        static int maximumToys(int[] toyPrices, int budget)
        {
            //Sorting the prices array in ascending order using Bubble sort
            int[] sortPrices = BubbleSort(toyPrices);
            try
            {
                //Comparing the sorted array with Mark's budget to find the maximum number of toys
                int maxToys = 0;
                for (int count = 0; count < sortPrices.Length; count++)
                {
                    budget = budget - sortPrices[count];

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
                Console.WriteLine("Exception occurred while computing maximumToys()");

            }
            return 0;
        }


        // balancedSums function
        static string balancedSums(int[] arr2)
        {
            try
            { 
                bool balance_check = false;// to check whether it's balanced around an element or not
                for (int i = 0; i < arr2.Length; i++)
                {
                    int sum_l = 0;// sum of left elements
                    int sum_r = 0;// sum of right elements
                    for (int j = 0; j < i; j++)
                    {
                        sum_l += arr2[j];// getting sum of all elements to the left
                    }
                    for (int k = i + 1; k < arr2.Length; k++)
                    {
                        sum_r += arr2[k];// getting sum of all elements to the right
                    }
                    if (sum_l == sum_r)
                    {
                        balance_check = true;// if element passes the criteria
                    }
                }
                if (balance_check == true)// returning values
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
        // Complete the missingNumbers function below.
        static void missingNumbers(int[] ar1, int[] ar2)
        {
            try
            {
                int min1 = ar1.Min();
                int min2 = ar2.Min();
                int max1 = ar1.Max();
                int max2 = ar2.Max();

                int min = Math.Min(min1, min2);
                int max = Math.Max(max1, max2);

                int[] aFreq = new int[max - min + 1];//Create two frequency arrays that 								maintains the frequency of each element
                int[] bFreq = new int[max - min + 1];

                for (int i = 0; i < ar1.Length; i++)//Iterate ar1 to find frequency of 								smallest value and store at index 0
                {
                    aFreq[ar1[i] - min]++;
                }
                for (int i = 0; i < ar2.Length; i++)//Iterate ar2 to find frequency of 								smallest value and store at index 0
                {
                    bFreq[ar2[i] - min]++;
                }
                for (int i = 0; i < aFreq.Length; i++)//Iterate frequency array and print 								the number obtained by
                                                      //adding current index to minimum 									value
                {
                    if (aFreq[i] != bFreq[i])
                    {
                        Console.Write(i + min + " ");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Exception occurred!");
            }
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
        static int findmedian(int[] a)
        {
            try
            {
                int[] new_arr = BubbleSort(a);//Sorted array
                int median_arr;// median of the array
                if (new_arr.Length % 2 != 0)// median principle for odd length while taking into consideration that array indexing starts form 0
                {
                    median_arr = new_arr[(new_arr.Length - 1) / 2];
                }
                else// throw exception if array length is even
                {
                    throw new Exception();
                }
                return median_arr;// returns median
            }

            catch
            {
                Console.WriteLine("Enter an array with odd number of elements.");
            }
            return 0;
            
        }


        // closestNumbers function
        static int[] ClosestNumbers(int[] arr)
        {
            try
            {
                int[] sortarr = BubbleSort(arr);//Using BubbleSort method to sort the array
                int diff = int.MaxValue; //diff represents the maximum value that int can represent
                                         //Tracking lowest value was difficult so starting with high value
                ArrayList results = new ArrayList();
                results.Add(sortarr[0] + " " + sortarr[1]);
                int index;
                for (index = 0; index < sortarr.Length - 1; index++)
                {
                    int tmp = sortarr[index + 1] - sortarr[index];
                    if (tmp < diff)
                    {
                        diff = tmp; //If difference of current and subsequent element is less than diff then clear the array
                        results.Clear();
                        results.Add(sortarr[index]); //Add current and subsequent element into array
                        results.Add(sortarr[index + 1]);
                    }
                    else if (diff == tmp) //If difference of current and subsequent element is equal to diff
                    {
                        results.Add(sortarr[index]);// Add current and subsequent element into array
                        results.Add(sortarr[index + 1]);
                    }
                }
                Console.WriteLine(String.Join(" ", results.ToArray())); //Display valid pairs in a single line
            }
            catch
            {
                Console.WriteLine("Exception Occurred!");
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
