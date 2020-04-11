using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Calc(double a, double b);
    class Calculator
    {
        public static void Sum(double a, double b)
        {
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
        }
        public static void Dif(double a, double b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }
        public static void Mult(double a, double b)
        {
            Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
        }
        public static void Div(double a, double b)
        {
            if (b != 0)
                Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            else throw new DivideByZeroException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc(Calculator.Sum);
            calc += Calculator.Dif;
            calc += Calculator.Mult;
            calc += Calculator.Div;
            Console.WriteLine("Enter 2 numbers:");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            calc(a, b);
            foreach (Calc c in calc.GetInvocationList())
                Console.WriteLine("{0}", c.Method.Name);
        }
    }
}
