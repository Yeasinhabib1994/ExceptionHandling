using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, an unexpected error occured");
            }
        }
    }

    public class Calculator
    {
        public int Divide(int a, int b)
        {
            return a / b;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
