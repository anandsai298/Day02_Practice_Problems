// See https://aka.ms/new-console-template for more information
using System;
namespace Day02_Practice_Problems;
class program
{
    static void Main(string[] args)
    {
        OpeartionDay2 opeartionDay2 = new OpeartionDay2();
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("Select your Option");
            Console.WriteLine("1.Factotrial\n2.Num_1_100\n3.Roots_Quadratic_Equation\n4.Number_String\n5.Char_Present_String\n6.Float_Array_Avg\n7.Second_Largest\n8.First_Repeated_Value\n9.opeartionDay2\n10.ShiftZeros");
            int option=Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    int num=Convert.ToInt32(Console.ReadLine());
                    int res=OpeartionDay2.Factorial(num);
                    Console.WriteLine("Factotial of" + num + "is :" + res);
                    break;
                case 2:
                    opeartionDay2.Num_1_100(1);
                    break;
                case 3:
                    opeartionDay2.Roots_Quadratic_Equation();
                    break;
                case 4:
                    opeartionDay2.Number_String();
                    break;
                case 5:
                    opeartionDay2.Char_Present_String();
                    break;
                case 6:
                    float Avg=OpeartionDay2.Float_Array_Avg();
                    Console.WriteLine("Average value of float array"+Avg);
                    break;
                case 7:
                    int res_SL = OpeartionDay2.Second_Largest();
                    Console.WriteLine("Second largest number in int array is : " + res_SL);
                    break;
                case 8:
                    opeartionDay2.First_Repeated_Value();
                    break;
                case 9:
                    opeartionDay2.Prime_Number_Array();
                    break;
                case 10:
                    opeartionDay2.ShiftZeros();
                    break;
            }
        }
    }
}

