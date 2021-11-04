using System;

namespace Calculator
{
    public class CalculatorApp

    {
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Substract(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        public double Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                return 0;
            }
            else
            {
                return (double)number1 / (double)number2;
            }            
        }

        public bool IsPrime(int number)
        {
            throw new NotImplementedException();
        }
    }    
}
