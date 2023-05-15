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
            Console.WriteLine("the saqure root of " + num + "is -->" + res);
        }
        public  void PrimeNumbers(int min,int Max)
        {
            int Count = 0;
            for (int i = min; i <(Max); i++)
            {
                bool IsPrime=true;
                for (int j=min;j<=Math.Sqrt(i);j++)
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

            Console.WriteLine("Temperature in Kelvin: "+ Kelvin);
            Console.WriteLine("Temperature in Fahrenheit:"+ Fahrenheit);
        }
        public void Sum_Array_Elements()
        {
            int sum = 0;
            Console.WriteLine("Enter elements in an array");
            int[] arr = {1,2,3,4,5,6,7,8,9};
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine("Sum of the elements in array is -->" + sum);
        }
        public void Ht_Dwarf_Tall_Avg()
        {
            Console.WriteLine("Enter height value");
            double Ht = Convert.ToDouble(Console.ReadLine());
            if(Ht<150)
            {
                Console.WriteLine("Dwarf Ht");
            }
            else if (Ht > 150 && Ht<160)
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
            if(!file.Directory.Exists)
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
            char ch= Convert.ToChar(Console.ReadLine());
            switch(ch)
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
    }
}



