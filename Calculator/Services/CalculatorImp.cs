using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Services
{
    public class CalculatorImp
    {
        public int Sum(int num1, int num2)
        {
            int res = num1 + num2;
            return res;
        }
           public int Sub(int num1, int num2)
        {
            int res = num1 - num2;
            return res;
        }
           public int Div(int num1, int num2)
        {
            int res = num1/num2;
            return res;
        }
           public int Multi(int num1, int num2)
        {
            int res = num1 * num2;
            return res;
        }
        static void Main()
        {

        }
    }
}