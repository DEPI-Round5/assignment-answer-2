using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // =========================================================================
            // Question 1: Check if a number can be divided by 3 and 4
            // =========================================================================
            Console.WriteLine("----- Question 1 -----");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q1Num))
            {
                if (q1Num % 3 == 0 && q1Num % 4 == 0)
                    Console.WriteLine("Output: Yes");
                else
                    Console.WriteLine("Output: No");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 2: Check if integer is positive or negative
            // =========================================================================
            Console.WriteLine("----- Question 2 -----");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int q2Num))
            {
                if (q2Num < 0)
                    Console.WriteLine("Output: negative");
                else
                    Console.WriteLine("Output: positive");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 3: Find max and min element among 3 integers
            // =========================================================================
            Console.WriteLine("----- Question 3 -----");
            Console.Write("Enter 3 integers (separated by space or comma): ");
            string input3 = Console.ReadLine();
            string[] parts3 = input3.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts3.Length >= 3)
            {
                int a = int.Parse(parts3[0]);
                int b = int.Parse(parts3[1]);
                int c = int.Parse(parts3[2]);

                int max = Math.Max(a, Math.Max(b, c));
                int min = Math.Min(a, Math.Min(b, c));

                Console.WriteLine($"max element = {max}");
                Console.WriteLine($"min element = {min}");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 4: Check if a number is even or odd
            // =========================================================================
            Console.WriteLine("----- Question 4 -----");
            Console.Write("Enter an integer number: ");
            if (int.TryParse(Console.ReadLine(), out int q4Num))
            {
                if (q4Num % 2 == 0)
                    Console.WriteLine("Output: Even");
                else
                    Console.WriteLine("Output: Odd");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 5: Check if character is vowel or consonant
            // =========================================================================
            Console.WriteLine("----- Question 5 -----");
            Console.Write("Enter a character: ");
            string q5Input = Console.ReadLine();
            if (!string.IsNullOrEmpty(q5Input))
            {
                char ch = char.ToLower(q5Input[0]);
                if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    Console.WriteLine("Output: vowel");
                else
                    Console.WriteLine("Output: Consonant");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 6: Print all numbers between 1 to N
            // =========================================================================
            Console.WriteLine("----- Question 6 -----");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int q6Num))
            {
                Console.Write("Output: ");
                for (int i = 1; i <= q6Num; i++)
                {
                    Console.Write(i + (i < q6Num ? ", " : ""));
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 7: Print multiplication table up to 12
            // =========================================================================
            Console.WriteLine("----- Question 7 -----");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int q7Num))
            {
                Console.Write("Output: ");
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write((q7Num * i) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 8: Print all even numbers between 1 to N
            // =========================================================================
            Console.WriteLine("----- Question 8 -----");
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int q8Num))
            {
                Console.Write("Output: ");
                for (int i = 2; i <= q8Num; i += 2)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 9: Calculate power of two integers
            // =========================================================================
            Console.WriteLine("----- Question 9 -----");
            Console.Write("Enter base and exponent (separated by space): ");
            string[] parts9 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts9.Length >= 2)
            {
                int baseNum = int.Parse(parts9[0]);
                int exp = int.Parse(parts9[1]);
                long powerResult = 1;
                for (int i = 0; i < exp; i++)
                {
                    powerResult *= baseNum;
                }
                Console.WriteLine($"Output: {powerResult}");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 10: Total, average and percentage for five subjects
            // =========================================================================
            Console.WriteLine("----- Question 10 -----");
            Console.Write("Enter Marks of five subjects: ");
            string[] parts10 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (parts10.Length >= 5)
            {
                int total = 0;
                for (int i = 0; i < 5; i++)
                {
                    total += int.Parse(parts10[i]);
                }
                int average = total / 5;
                int percentage = (total * 100) / 500;

                Console.WriteLine($"Total marks = {total}");
                Console.WriteLine($"Average Marks = {average}");
                Console.WriteLine($"Percentage = {percentage}");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 11: Number of days in a month
            // =========================================================================
            Console.WriteLine("----- Question 11 -----");
            Console.Write("Month Number: ");
            if (int.TryParse(Console.ReadLine(), out int month))
            {
                int days = month switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 28,
                    _ => 0
                };
                if (days > 0)
                    Console.WriteLine($"Days in Month: {days}");
                else
                    Console.WriteLine("Invalid Month Number!");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 12: Simple Calculator
            // =========================================================================
            Console.WriteLine("----- Question 12 -----");
            Console.Write("Enter first number: ");
            double calcNum1 = double.Parse(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];
            Console.Write("Enter second number: ");
            double calcNum2 = double.Parse(Console.ReadLine());

            switch (op)
            {
                case '+': Console.WriteLine($"Result = {calcNum1 + calcNum2}"); break;
                case '-': Console.WriteLine($"Result = {calcNum1 - calcNum2}"); break;
                case '*': Console.WriteLine($"Result = {calcNum1 * calcNum2}"); break;
                case '/': Console.WriteLine(calcNum2 != 0 ? $"Result = {calcNum1 / calcNum2}" : "Cannot divide by zero"); break;
                default: Console.WriteLine("Invalid Operator"); break;
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 13: Reverse a string
            // =========================================================================
            Console.WriteLine("----- Question 13 -----");
            Console.Write("Enter a string: ");
            string str13 = Console.ReadLine();
            char[] charArray13 = str13.ToCharArray();
            Array.Reverse(charArray13);
            Console.WriteLine("Reversed String: " + new string(charArray13));

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 14: Reverse an integer
            // =========================================================================
            Console.WriteLine("----- Question 14 -----");
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int num14))
            {
                int rev14 = 0;
                int temp14 = Math.Abs(num14);
                while (temp14 > 0)
                {
                    rev14 = rev14 * 10 + temp14 % 10;
                    temp14 /= 10;
                }
                if (num14 < 0) rev14 = -rev14;
                Console.WriteLine("Reversed Integer: " + rev14);
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 15: Find prime numbers within a range
            // =========================================================================
            Console.WriteLine("----- Question 15 -----");
            Console.Write("Input starting number of range: ");
            int start15 = int.Parse(Console.ReadLine());
            Console.Write("Input ending number of range: ");
            int end15 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The prime numbers between {start15} and {end15} are:");
            for (int i = Math.Max(2, start15); i <= end15; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 16: Decimal to binary without array
            // =========================================================================
            Console.WriteLine("----- Question 16 -----");
            Console.Write("Enter a number to convert: ");
            if (int.TryParse(Console.ReadLine(), out int decNum))
            {
                string binaryStr = "";
                int tempDec = decNum;
                if (tempDec == 0) binaryStr = "0";
                while (tempDec > 0)
                {
                    binaryStr = (tempDec % 2) + binaryStr;
                    tempDec /= 2;
                }
                Console.WriteLine($"The Binary of {decNum} is {binaryStr}.");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 17: Check if 3 points lie on a single straight line
            // =========================================================================
            Console.WriteLine("----- Question 17 -----");
            Console.Write("Enter x1 y1: ");
            string[] p1 = Console.ReadLine().Split();
            Console.Write("Enter x2 y2: ");
            string[] p2 = Console.ReadLine().Split();
            Console.Write("Enter x3 y3: ");
            string[] p3 = Console.ReadLine().Split();

            double x1 = double.Parse(p1[0]), y1 = double.Parse(p1[1]);
            double x2 = double.Parse(p2[0]), y2 = double.Parse(p2[1]);
            double x3 = double.Parse(p3[0]), y3 = double.Parse(p3[1]);

            // Area of triangle check: (x1*(y2-y3) + x2*(y3-y1) + x3*(y1-y2)) == 0
            if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1))
                Console.WriteLine("Output: Points lie on a single straight line.");
            else
                Console.WriteLine("Output: Points do NOT lie on a single straight line.");

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 18: Evaluate worker efficiency
            // =========================================================================
            Console.WriteLine("----- Question 18 -----");
            Console.Write("Enter time taken in hours: ");
            if (double.TryParse(Console.ReadLine(), out double timeTaken))
            {
                if (timeTaken >= 2 && timeTaken <= 3)
                    Console.WriteLine("Highly efficient.");
                else if (timeTaken > 3 && timeTaken <= 4)
                    Console.WriteLine("Instructed to increase speed.");
                else if (timeTaken > 4 && timeTaken <= 5)
                    Console.WriteLine("Provided with training to enhance speed.");
                else if (timeTaken > 5)
                    Console.WriteLine("Required to leave the company.");
                else
                    Console.WriteLine("Time below 2 hours.");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 19: Print identity matrix of size N*N
            // =========================================================================
            Console.WriteLine("----- Question 19 -----");
            Console.Write("Enter matrix size n: ");
            if (int.TryParse(Console.ReadLine(), out int n19))
            {
                for (int i = 0; i < n19; i++)
                {
                    for (int j = 0; j < n19; j++)
                    {
                        Console.Write((i == j ? 1 : 0) + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 20: Sum of all elements of an array
            // =========================================================================
            Console.WriteLine("----- Question 20 -----");
            Console.Write("Enter array elements separated by space: ");
            int[] arr20 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int sum20 = 0;
            foreach (int val in arr20) sum20 += val;
            Console.WriteLine("Sum of array elements = " + sum20);

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 21: Merge two arrays of same size sorted in ascending order
            // =========================================================================
            Console.WriteLine("----- Question 21 -----");
            Console.Write("Enter First Array elements: ");
            int[] arr21_1 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Console.Write("Enter Second Array elements: ");
            int[] arr21_2 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

            int[] merged = new int[arr21_1.Length + arr21_2.Length];
            arr21_1.CopyTo(merged, 0);
            arr21_2.CopyTo(merged, arr21_1.Length);
            Array.Sort(merged);

            Console.WriteLine("Merged and Sorted Array: " + string.Join(" ", merged));

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 22: Count frequency of each element in an array
            // =========================================================================
            Console.WriteLine("----- Question 22 -----");
            Console.Write("Enter array elements: ");
            int[] arr22 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Dictionary<int, int> freqMap = new Dictionary<int, int>();
            foreach (int item in arr22)
            {
                if (freqMap.ContainsKey(item)) freqMap[item]++;
                else freqMap[item] = 1;
            }
            foreach (var kvp in freqMap)
            {
                Console.WriteLine($"Element {kvp.Key} occurs {kvp.Value} times.");
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 23: Maximum and Minimum element in an array
            // =========================================================================
            Console.WriteLine("----- Question 23 -----");
            Console.Write("Enter array elements: ");
            int[] arr23 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int max23 = arr23[0], min23 = arr23[0];
            for (int i = 1; i < arr23.Length; i++)
            {
                if (arr23[i] > max23) max23 = arr23[i];
                if (arr23[i] < min23) min23 = arr23[i];
            }
            Console.WriteLine($"Maximum element = {max23}");
            Console.WriteLine($"Minimum element = {min23}");

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 24: Find second largest element in an array
            // =========================================================================
            Console.WriteLine("----- Question 24 -----");
            Console.Write("Enter array elements: ");
            int[] arr24 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);
            int firstMax = int.MinValue, secondMax = int.MinValue;
            foreach (int item in arr24)
            {
                if (item > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = item;
                }
                else if (item > secondMax && item < firstMax)
                {
                    secondMax = item;
                }
            }
            Console.WriteLine("Second largest element = " + (secondMax != int.MinValue ? secondMax.ToString() : "None"));

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 25: Longest distance between two equal cells in an array
            // =========================================================================
            Console.WriteLine("----- Question 25 -----");
            Console.Write("Enter number of elements (N): ");
            if (int.TryParse(Console.ReadLine(), out int n25))
            {
                int[] arr25 = new int[n25];
                Console.WriteLine("Enter array elements one by one:");
                for (int i = 0; i < n25; i++)
                {
                    arr25[i] = int.Parse(Console.ReadLine());
                }

                int maxDistance = 0;
                for (int i = 0; i < n25; i++)
                {
                    for (int j = n25 - 1; j > i; j--)
                    {
                        if (arr25[i] == arr25[j])
                        {
                            int distance = j - i - 1;
                            if (distance > maxDistance)
                            {
                                maxDistance = distance;
                            }
                            break;
                        }
                    }
                }
                Console.WriteLine("Longest distance between two equal cells = " + maxDistance);
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 26: Reverse order of words using string Split
            // =========================================================================
            Console.WriteLine("----- Question 26 -----");
            Console.Write("Input: ");
            string input26 = Console.ReadLine();
            Console.WriteLine(string.Join(" ", input26.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse()));

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 27: Copy 2D array elements to second array
            // =========================================================================
            Console.WriteLine("----- Question 27 -----");
            Console.Write("Enter rows count: ");
            int rows27 = int.Parse(Console.ReadLine());
            Console.Write("Enter cols count: ");
            int cols27 = int.Parse(Console.ReadLine());

            int[,] arr1_2D = new int[rows27, cols27];
            int[,] arr2_2D = new int[rows27, cols27];

            Console.WriteLine("Enter elements of first 2D array:");
            for (int i = 0; i < rows27; i++)
            {
                for (int j = 0; j < cols27; j++)
                {
                    arr1_2D[i, j] = int.Parse(Console.ReadLine());
                    arr2_2D[i, j] = arr1_2D[i, j]; // Copy element
                }
            }

            Console.WriteLine("Second Array Elements:");
            for (int i = 0; i < rows27; i++)
            {
                for (int j = 0; j < cols27; j++)
                {
                    Console.Write(arr2_2D[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------------------------------------\n");

            // =========================================================================
            // Question 28: Print 1D Array in Reverse Order
            // =========================================================================
            Console.WriteLine("----- Question 28 -----");
            Console.Write("Enter array elements: ");
            int[] arr28 = Array.ConvertAll(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries), int.Parse);

            Console.Write("Reversed Array: ");
            for (int i = arr28.Length - 1; i >= 0; i--)
            {
                Console.Write(arr28[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\n=========================================================================");
            Console.WriteLine("End of Assignment 3");
            Console.WriteLine("=========================================================================");

            Console.ReadLine(); // Keeps console open
        }
    }
}