using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02_Practice_Problems
{
    public class Sum:BaseClass
    {
        public void GetSum()
        {
            int res = Num1 + Num2;
            Console.WriteLine("sum of Two Num's: "+res);
        }
    }
}
