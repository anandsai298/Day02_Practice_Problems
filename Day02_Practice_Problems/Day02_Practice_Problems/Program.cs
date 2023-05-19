// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Day02_Practice_Problems;
class program
{
    static void Main(string[] args)
    {
        EmployeeOperations employeeOperations = new EmployeeOperations();
        OpeartionDay2 opeartionDay2 = new OpeartionDay2();
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("Select your Option");
            Console.WriteLine("1.Factotrial\n2.Num_1_100\n3.Roots_Quadratic_Equation\n4.Number_String\n5.Char_Present_String\n6.Float_Array_Avg\n7.Second_Largest\n8.First_Repeated_Value\n9.Prime_Number_Array\n10.ShiftZeros\n11.Delete_Array\n12.Days_Into_Y_M_W\n13.SquareRoot\n14.PrimeNumbers\n15.Celsius_Kelvin_FahrenHeit\n16.Sum_Array_Elements\n17.Ht_Dwarf_Tall_Avg\n18.Inheritance_Sum\n19.FilePath_Create_Read\n20.Check_Operators\n21.Reverse_String\n22.Remove_Duplicates\n23.Positive_Numbers\n24.Num_Count_Sequence\n25.Linear\n26.Hr_Min_Sec\n27.Num_Square\n28.Type_Of_Input\n29.N1_Itself_N2\n30.Smallest_Gap\n31.Palindrome\n32.VendingMachine\n33.TimeSlot\n34.Sum_Digits_Num\n35.Square_In_Array\n36.Prefix\n37.Num_Intersection\n38.GetAllStudentDetails\n39.EmployeeOperations\n40.AddEmployee\n41.DeleteEmployee\n42.UpdateEmployee\n43.GetAllEmployeeDetails\n44.PyramidArrangement");
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
                case 21:
                    opeartionDay2.Reverse_String();
                    break;
                case 22:
                    opeartionDay2.Duplicate();
                    break;
                case 23:
                    opeartionDay2.Positive_Numbers();
                    break;
                case 24:
                    opeartionDay2.Num_Count_Sequence();
                    break;
                case 25:
                    opeartionDay2.Linear();
                    break;
                case 26:
                    opeartionDay2.Hr_Min_Sec();
                    break;
                case 27:
                    opeartionDay2.Num_Square();
                    break;
                case 28:
                    opeartionDay2.Type_Of_Input('a');
                    opeartionDay2.Type_Of_Input(28);
                    opeartionDay2.Type_Of_Input("@");
                    break;
                case 29:
                    opeartionDay2.N1_Itself_N2();
                    break;
                case 30:
                    opeartionDay2.Smallest_Gap();
                    break;
                case 31:
                    opeartionDay2.Palindrome();
                    break;
                case 32:
                    opeartionDay2.VendingMachine();
                    break;
                case 33:
                    opeartionDay2.TimeSlot();
                    break;
                case 34:
                    opeartionDay2.Sum_Digits_Num();
                    break;
                case 35:
                    opeartionDay2.Square_In_Array();
                    break;
                case 36:
                    opeartionDay2.Prefix();
                    break;
                case 37:
                    opeartionDay2.Num_Intersection();
                    break;
                case 38:
                    StudentOperation studentOperation = new StudentOperation();
                    studentOperation.GetAllStudentDetails();
                    break;
                case 39:
                    employeeOperations.GetAllEmployeeDetails();
                    break;
                case 40:
                    EmployeeDetails emp = new EmployeeDetails()
                    {
                        Name = "Rowthu",
                        Age = 25,
                        Salary = 30000
                    };
                    employeeOperations.AddEmployee(emp);
                    break;
                case 41:
                    employeeOperations.DeleteEmployee(1);
                    break;
                case 42:
                    employeeOperations.UpadteEmployee(5, "Ask");
                    break;
                case 43:
                    employeeOperations.GetAllEmployeeDetails();
                    break;
                case 44:
                    opeartionDay2.Pyramid();
                    break;
            }
        }
    }
}

