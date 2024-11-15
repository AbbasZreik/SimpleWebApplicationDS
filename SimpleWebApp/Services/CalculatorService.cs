﻿namespace SimpleWebApp.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b) => b == 0 ? throw new DivideByZeroException() : (double)a / b;
    }

}
