using System;

namespace MyApplication
{
    public class Calculator
    {
        public Calculator(string v)
        {
        }
        public int Addition(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Subtraction(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Multiplication(int n1, int n2)
        {
            return n1 * n2;
        }
        public int Division(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
