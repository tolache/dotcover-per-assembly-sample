﻿namespace MyLibrary1;

public class Class1
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;

    public double Divide(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Division by zero is not allowed.");
        return (double)a / b;
    }
}
