using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Dynamic;

namespace Day02_Practice_Problems
{
    public class OpeartionDay2
    {
        public static int Factorial(int num)
        {

            if (num == 0)
                return 1;
            else
                return num * Factorial(num - 1);
        }
        public void Num_1_100(int n)
        {
            if (n <= 100)
            {
                Console.WriteLine(n);
                Num_1_100(n + 1);
            }
        }
        public void Roots_Quadratic_Equation()
        {
            Console.WriteLine("Enter value of a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of c");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminent = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("discriminent" + discriminent);
            double root1, root2;
            if (discriminent > 0)
            {
                root1 = (-b + Math.Sqrt(discriminent)) / (2 * a);
                root2 = (-b - Math.Sqrt(discriminent)) / (2 * a);
                Console.WriteLine("Roots are real and different" + "\n" + "Root1-->" + root1 + "\n" + "Root2-->" + root2);
            }
            else if (discriminent == 0)
            {
                root1 = (-b / (2 * a));
                Console.WriteLine("roots are real and equal" + "\n" + "Root1=Root2-->" + root1);
            }
            else
                Console.WriteLine("Roots are imaginary");
        }
        public void Number_String()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0 && num % 7 == 0)
            {
                Console.WriteLine("Pling Plang Plong");
            }
            else if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Pling Plang ");
            }

            else if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine("Pling Plong ");
            }
            else if (num % 7 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Plang Plong ");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("Pling");
            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Plang");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("Plong");
            }
            else
                Console.WriteLine(num);
        }
        public void Char_Present_String()
        {
            Console.WriteLine("Enter any string");
            string s = Console.ReadLine();
            bool has_a = false;
            bool has_e = false;
            bool has_p = false;
            foreach (Char ch in s)
            {
                if (ch == 'a')
                {
                    has_a = true;
                    Console.WriteLine("char a is present");
                }
                else if (ch == 'e')
                {
                    has_e = true;
                    Console.WriteLine("char e is present");
                }
                else if (ch == 'p')
                {
                    has_p = true;
                    Console.WriteLine("char p is present ");
                }
            }
            if (has_a && has_e && has_p)
            {
                Console.WriteLine("ALL PRESENT");
            }
            else if (has_a || has_e || has_p)
            {
                Console.WriteLine("ONE or MORE PRESENT");
            }
            else
            {
                Console.WriteLine("NONE PRESENT");
            }
        }
        public static float Float_Array_Avg()
        {
            float[] num = { 10.5f, 25.5f, 45.5f, 65.5f };
            float sum = 0;
            foreach (float f in num)
            {
                sum += f;
            }
            float Avg = sum / num.Length;
            return Avg;

        }
        public static int Second_Largest()
        {
            int[] arr = { 2, 9, 1, 4, 6 };
            int larg_Num = 0;
            int Sec_larg = 0;
            foreach (int i in arr)
            {
                if (i > larg_Num)
                {
                    Sec_larg = larg_Num;
                    larg_Num = i;
                }
                else if (i > Sec_larg && i != larg_Num)
                {
                    Sec_larg = i;
                }
            }
            return Sec_larg;
        }
        public void First_Repeated_Value()
        {
            int[] arr = new int[5];
            int value = 0;
            Console.WriteLine("Enter 5 values");
            for (int i = 0; i < 5; i++)
            {
                int element = Convert.ToInt32(Console.ReadLine());
                arr[i] = element;
            }
            for (int j = 0; j < 5; j++)
            {
                for (int k = j + 1; k < 5; k++)
                {
                    if (arr[j] == arr[k])
                    {
                        value = arr[j];
                        Console.WriteLine("value that first repeated is --> " + value);
                        return;
                    }
                }
            }
            Console.WriteLine(" no repeated value was found");
        }
        public void Prime_Number_Array()
        {
            static bool IsPrime(int num)
            {
                if (num < 2)
                {
                    return false;
                }

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Enter the elements of the array ");
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                arr[i] = ele;
            }
            Console.WriteLine("Prime numbers in the array:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        public void ShiftZeros()
        {
            int[] arr = { 12, 0, 42, 0, 4 };
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[count] = arr[i];
                    count++;
                }
            }
            while (count < arr.Length)
            {
                arr[count] = 0;

                count++;
            }
            foreach (int num in arr)
                Console.Write(num + "\n");
        }
        public void Delete_Array()
        {
            int del = 2;
            int[] arr = new int[5];
            Console.WriteLine("Original Array:");
            for (int i = 0; i < 5; i++)
            {
                int d = Convert.ToInt32(Console.ReadLine());
                arr[i] = d;
            }
            for (int i = del; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("\nArray after deleting element at index 2:", del);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Days_Into_Y_M_W()
        {
            Console.Write("Enter the number of days: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int years = totalDays / 365;
            int remainingDays = totalDays % 365;
            int months = remainingDays / 30;
            remainingDays = remainingDays % 30;
            int weeks = remainingDays / 7;
            remainingDays = remainingDays % 7;

            Console.WriteLine("Years:" + years + "\n" + "Months:" + months + "\n" + "Weeks:" + weeks + "\n" + "Days:" + remainingDays);
        }
        public void SquareRoot()
        {
            Console.WriteLine("Enter number to find square root");
            double num = Convert.ToInt32(Console.ReadLine());
            double res = Math.Pow((num), 0.5);
            Console.WriteLine("the square root of " + num + "is -->" + res);
        }
        public void PrimeNumbers(int min, int Max)
        {
            int Count = 0;
            for (int i = min; i < (Max); i++)
            {
                bool IsPrime = true;
                for (int j = min; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Count++;
                    Console.WriteLine(i + " ");
                }
            }
            Console.WriteLine("count of prime numbers" + Count);
        }
        public void Celsius_Kelvin_FahrenHeit()
        {
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double Kelvin = celsius + 273.15;
            double Fahrenheit = celsius * 1.8 + 32;

            Console.WriteLine("Temperature in Kelvin: " + Kelvin);
            Console.WriteLine("Temperature in Fahrenheit:" + Fahrenheit);
        }
        public void Sum_Array_Elements()
        {
            int sum = 0;
            Console.WriteLine("Enter elements in an array");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Sum of the elements in array is -->" + sum);
        }
        public void Ht_Dwarf_Tall_Avg()
        {
            Console.WriteLine("Enter height value");
            double Ht = Convert.ToDouble(Console.ReadLine());
            if (Ht < 150)
            {
                Console.WriteLine("Dwarf Ht");
            }
            else if (Ht > 150 && Ht < 160)
            {
                Console.WriteLine("AVERAGE Ht");
            }
            else if (Ht > 160)
            {
                Console.WriteLine("TALL Ht");
            }
            else
            {
                Console.WriteLine("Invalid Height Input");
            }
        }
        public void FilePath()
        {
            string filePath = "c:/csharp/ex/test.txt";
            FileInfo file = new FileInfo(filePath);
            if (!file.Directory.Exists)
            {
                Directory.CreateDirectory(file.Directory.FullName);
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("ANAND SAI KUMAR VIJAYAROWTHU");
                }
            }
            else if (file.Exists)
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string data = reader.ReadToEnd();
                    Console.WriteLine("File exists and read Data from the file:");
                    Console.WriteLine(data);
                }
            }
        }
        public void Check_Operators()
        {
            Console.WriteLine("Enter Character Value");
            char ch = Convert.ToChar(Console.ReadLine());
            switch (ch)
            {
                case '+':
                case '-':
                case '*':
                    Console.WriteLine("Arthematic operator");
                    break;
                case '&':
                case '|':

                    Console.WriteLine("Logical operator");
                    break;
                case '=':
                case '>':
                case '<':
                    Console.WriteLine("Relational operator");
                    break;

            }
        }
        public void Reverse_String()
        {
            Console.WriteLine("Enter string of sentence");
            string sentence = Console.ReadLine();
            string[] arr = sentence.Split(" ");
            Array.Reverse(arr);
            string reverse = string.Join(" ", arr);
            Console.WriteLine("Original sentence-->" + sentence + "\n" + "Reverse order of an sentence-->" + reverse);
        }
        public void Duplicate()
        {
            object[] arr = { 25, "Anna", false, 25, 112.22, "Anna", false };
            object[] arr2 = Remove_Duplicates(arr);
            Console.WriteLine("before not removing duplicates array -->" + string.Join(",", arr) + "\n" + "after duplicates removed array -->" + string.Join(",", arr2));
            static object[] Remove_Duplicates(object[] arr)
            {
                int index = 0;
                object[] arr2 = new object[arr.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < index; j++)
                    {
                        if (arr[i].Equals(arr2[j]))
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    if (!isDuplicate)
                    {
                        arr2[index++] = arr[i];
                    }
                }
                Array.Resize(ref arr2, index);
                return arr2;
            }
        }
        public void Positive_Numbers()
        {
            List<int> num = new List<int> { 1, 2, 6, 4, -7, -5, 7 };
            foreach (int i in num)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public void Num_Count_Sequence()
        {
            int count = 1;
            Console.WriteLine("Enter number upto which it should repeat");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(count + " ");
                }
                count++;
            }
        }
        public void Linear()
        {
            Console.WriteLine("Enter x1 value");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y1 value");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 value");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y2 value");
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x3 value");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y3 value");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double slope1 = (y2 - y1) / (x2 - x1);
            double slope2 = (y3 - y2) / (x3 - x2);
            if (slope1 == slope2)
            {
                Console.WriteLine(" 3 points places on same line");
            }
            else
            {
                Console.WriteLine("3 points not placed on same line");
            }
        }
        public void Hr_Min_Sec()
        {
            Console.WriteLine("enter the value of hours");
            double Hr = Convert.ToDouble(Console.ReadLine());
            double min = Hr * 60;
            double sec = Hr * 3600;
            Console.WriteLine("Conversion of " + Hr + " Hours into Minutes -->" + min + "and Hours into seconds-->" + sec);
        }
        public void Num_Square()
        {
            int[] arr = { 1, 2, 3, 4 };
            foreach (int i in arr)
            {
                Console.WriteLine("Numbers in array:" + i + "Square of the number:" + Math.Pow(i, 2));
            }
            int count = arr.Count();
            Console.WriteLine("Count of an array numbers:" + count);
        }
        public void Type_Of_Input(object input)
        {
            if (input.GetType().Equals(typeof(char)))
            {
                Console.WriteLine("input is a character");
            }
            else if (input.GetType().Equals(typeof(int)))
            {
                Console.WriteLine("input is a integer");
            }
            else
            {
                Console.WriteLine("input is a Symbol");
            }
        }
        public void N1_Itself_N2()
        {
            Console.WriteLine("Enter value of N1 : ");
            double N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter value of N2 : ");
            double N2 = Convert.ToDouble(Console.ReadLine());
            double res = Math.Pow(N1, N2);
            Console.WriteLine("result of N1 and its power of N2 : " + res);
        }
        public void Smallest_Gap()
        {
            int[] arr = { 5, 10, 15, 18, 20 };
            int Gap = Calculate(arr);
            Console.WriteLine("Smallest gap between numbers are :" + Gap);
            static int Calculate(int[] arr)
            {
                Array.Sort(arr);
                int Gap = int.MaxValue;
                for (int i = 1; i < arr.Length; i++)
                {
                    int current = arr[i] - arr[i - 1];
                    if (current < Gap)
                    {
                        Gap = current;
                    }
                }
                return Gap;
            }
        }
        public void Palindrome()
        {
            Console.WriteLine("Enter value to check it is palindrome or not :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0, rem = 0;
            int temp = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = (sum * 10) + rem;
                num = num / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("the given value of " + temp + " is Palindrome");
            }
            else
                Console.WriteLine("Not an palindrome");
        }
        public void VendingMachine()
        {
            int[] coins = {100, 50,25, 10, 5, 1 };

            
            static void Get_Change(int amount, int[] coins, int Price)
            {
                int Count = 0;
                Console.WriteLine("notes change available");
                for (int i = 0; i < coins.Length; i++)
                {
                    int Change_Amount = amount - Price;
                    if (amount / coins[i] >= 1 && amount != 0)
                    {
                        int change = amount / coins[i];
                        Count += change;
                        Console.WriteLine(coins[i] + "--->" + change);
                        amount -= coins[i] * change;
                    }
                }
                Console.WriteLine("count of no of notes change -->" + Count);
            }
        }
        public void TimeSlot()
        {
            int[][] appointments = 
            {
                new int[] { 10, 12 },
                new int[] { 14, 15 },
                new int[] { 16, 20 }
            };
            int[][] availableSlots = AvailableTimeSlots(appointments);
            Console.WriteLine("Available Time Slots:");
            foreach (int[] slot in availableSlots)
            {
                Console.WriteLine("["+slot[0]+ slot[1]+"]");
            }
            static int[][] AvailableTimeSlots(int[][] appointments)
            {
                List<int[]> availableSlots = new List<int[]>();

                int startTime = 0;
                for (int i = 0; i < appointments.Length; i++)
                {
                    int[] appointment = appointments[i];
                    int endTime = appointment[0];

                    if (startTime < endTime)
                    {
                        availableSlots.Add(new int[] { startTime, endTime });
                    }

                    startTime = appointment[1];
                }

                if (startTime < 24)
                {
                    availableSlots.Add(new int[] { startTime, 24 });
                }

                return availableSlots.ToArray();
            }
        }  
        public void Sum_Digits_Num()
        {
            Console.WriteLine("Enter the number of digits (n):");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the sum of digits (sumN):");
            int sumN = int.Parse(Console.ReadLine());

            Console.WriteLine(n+"-->digit numbers with sum -->"+sumN+" are:");
            FindNumbersWithSum(n, sumN);

            static void FindNumbersWithSum(int n, int sumN)
            {
                int[] num = new int[n];
                FindNumbers(num, n, sumN, 0);
            }
            static void FindNumbers(int[] num, int n, int sumN, int pos)
            {
                if (pos == n)
                {
                    if (sumN == 0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(num[i]);
                        }
                        Console.WriteLine(" ");
                    }
                    return;
                }
                for (int i = 0; i <= 9; i++)
                {
                    if (sumN >= i)
                    {
                        num[pos] = i;
                        FindNumbers(num, n, sumN - i, pos + 1);
                    }
                }
            }
        }
        public void Square_In_Array()
        {
            int[] arr = { 121, 144, 25, 36, 7, 8, 5, 72 };
            foreach(int i in arr)
            {
                if (SquareRoot(i))
                {
                    Console.WriteLine("squares available in array are:" + i);
                }
            }
            static bool SquareRoot(int n)
            {
                int sqrt=(int)Math.Sqrt(n);
                return sqrt* sqrt==n;
            }
        }
        public void Prefix()
        {
            string[] arr = { "askanand", "asksai", "askkumar" };
            string prefix = FindLongestCommonPrefix(arr);
            int len = GetMinLength(arr);
            Console.WriteLine(" Common Prefix of the array :" + prefix+"\n"+"minlen"+len);
            static string FindLongestCommonPrefix(string[] arr)
            {
                if (arr.Length == 0)
                {
                    return "";
                }
                int minLength = GetMinLength(arr);
                string prefix = "";
                for (int i = 0; i < minLength; i++)
                {
                    char currentChar = arr[0][i];

                    for (int j = 1; j < arr.Length; j++)
                    {
                        if (arr[j][i] != currentChar)
                        {
                            return prefix;
                        }
                    }
                    prefix += currentChar;
                }
                return prefix;
            }
            static int GetMinLength(string[] arr)
            {
                int minLength = int.MaxValue;

                foreach (string str in arr)
                {
                    minLength = Math.Min(minLength, str.Length);
                }

                return minLength;
            }
        }
        public void Num_Intersection()
        {
            int[] num1 = { 10, 20 };
            int[] num2 = { 15, 25 };
            int[] intersection = PairIntersection(num1, num2);
            Console.WriteLine("interstion numbers between array num1 and num2:" + string.Join(",", intersection));
            static int[] PairIntersection(int[] num1, int[] num2)
            {
                int start = Math.Max(num1[0], num2[0]);
                int end = Math.Min(num1[1], num2[1]);

                if (start > end)
                {
                    return new int[0];
                }

                int[] intersection = new int[end - start + 1];
                for (int i = 0; i < intersection.Length; i++)
                {
                    intersection[i] = start + i;
                }

                return intersection;
            }
        }
        public void Pyramid()
        {
            int[] arr = { 1, 4, 3, 6, 8, 7, 9, 2, 5, 0, 12, 23, -1 };
            int n = arr.Length;

            Array.Sort(arr);
            Array.Reverse(arr);

            int mid = n % 2 == 1 ? n / 2 : (n / 2) - 1;
            int left = mid - 1;
            int right = mid + 1;

            while (left >= 0 && right < n)
            {
                if (arr[left] <= arr[right])
                {
                    Swap(arr, left, right);
                }
                left--;
                right++;
            }

            Console.WriteLine("After pyramid swapping left and right: " + string.Join(", ", arr));
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}






