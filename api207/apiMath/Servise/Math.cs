using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Lesson1
{
    class Math
    {
        private int Id = 123;
        internal string name;
        protected double Sallary;

        public int sum(double num1, int num2)
        {
            return Convert.ToInt32(num1) + num2;
        }
        public int mult(double num1, int num2)
        {
            return Convert.ToInt32(num1) * num2;
        }
        public int div(double num1, int num2)
        {
            return Convert.ToInt32(num1 / num2);
        }
        public int sub(double num1, int num2)
        {
            return Convert.ToInt32(num1 - num2);
        }
        public double percent(double num1, double num2)
        {
            return num1 * num2 / 100;
        }
        public double revpercent(double num1, double num2)
        {
            return num1 * 100 / num2;
        }

        public double Count(double[] numbers)
        {
            return numbers.Length;
        }

        public double max(double[] numbers)
        {
            var result = numbers[0];
            foreach (var number in numbers)
            {
                if (result < number)
                {
                    result = number;
                }
            }
            return result;
        }
        public double min(double[] numbers)
        {
            double result = numbers[0];
            foreach (var number in numbers)
            {
                if (result > number)
                {
                    result = number;
                }
            }
            return result;
        }
        public int factorial(int num)
        {
            if (num < 0)
            {
                return 0;
            }
            int result = 1;
            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
        public double sumar(double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        public int count(double[] numbers)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (n == 0)
                {
                    break;
                }
                count++;
            }
            return count;
        }
        public double dwr(double num1, double num2)
        {
            return (num1 % num2);
        }
    }
}