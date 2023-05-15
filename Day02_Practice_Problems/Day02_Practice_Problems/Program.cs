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
            Console.WriteLine("1.Factotrial\n2.Num_1_100\n3.Roots_Quadratic_Equation\n4.Number_String\n5.Char_Present_String\n6.Float_Array_Avg\n7.Second_Largest\n8.First_Repeated_Value\n9.Prime_Number_Array\n10.ShiftZeros\n11.Delete_Array\n12.Days_Into_Y_M_W\n13.SquareRoot\n14.PrimeNumbers\n15.Celsius_Kelvin_FahrenHeit\n16.Sum_Array_Elements\n17.Ht_Dwarf_Tall_Avg\n18.Inheritance_Sum\n19.FilePath_Create_Read\n20.Check_Operators");
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
                case 11:
                    opeartionDay2.Delete_Array();
                    break;
                case 12:
                    opeartionDay2.Days_Into_Y_M_W();
                    break;
                case 13:
                    opeartionDay2.SquareRoot();
                    break;
                case 14:
                    opeartionDay2.PrimeNumbers(2,100);
                    break;
                case 15:
                    opeartionDay2.Celsius_Kelvin_FahrenHeit();
                    break;
                case 16:
                    opeartionDay2.Sum_Array_Elements();
                    break;
                case 17:
                    opeartionDay2.Ht_Dwarf_Tall_Avg();
                    break;
                case 18:
                    Sum sum = new Sum();
                    sum.Num1 = 10;
                    sum.Num2 = 20;
                    sum.GetSum();
                    break;
                case 19:
                    opeartionDay2.FilePath();
                    break;
                case 20:
                    opeartionDay2.Check_Operators();
                    break;
            }
        }
    }
}

