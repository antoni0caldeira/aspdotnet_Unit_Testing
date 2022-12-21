using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{

    public class MathFormulas : IEnumerable<object[]>
    {
    public bool IsEven(int number) => number % 2 == 0;
    
    public static double Add(double num1, double num2) => num1 + num2;
    

    public static double Subtract(double num1, double num2) => num1 - num2;
    

    public static double Multiply(double num1, double num2) => num1 * num2;
    

    public static double Divide(double num1, double num2) => num1 / num2;

    public int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

    double Average(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum / numbers.Length;
        }

        public IEnumerator<object[]> GetEnumerator()
        {
            {
                yield return new object[] { 1, 2, 3 };
                yield return new object[] { -4, -6, -10 };
                yield return new object[] { -2, 2, 0 };
                yield return new object[] { int.MinValue, -1, int.MaxValue };
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public static IEnumerable<object[]> Data =>
    new List<object[]>
    {
            new object[] { 1, 2, 3 },
            new object[] { -4, -6, -10 },
            new object[] { -2, 2, 0 },
            new object[] { int.MinValue, -1, int.MaxValue },
    };
    }
    
    


        

}
