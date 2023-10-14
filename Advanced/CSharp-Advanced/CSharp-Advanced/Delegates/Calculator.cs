using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Advanced.Delegates
{
    delegate int MathOperator(int a, int b);
    public class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MathOperator addDelegate = Calculator.Add;
            MathOperator subDelegate = Calculator.Subtract;

            int result1 = addDelegate(1, 2);
            int result2 = subDelegate(10, 4);
        }
    }
}
