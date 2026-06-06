using System;

class Complex
{
    public int real, imag;

    // Constructor
    public Complex(int r, int i)
    {
        real = r;
        imag = i;
    }

    // Operator Overloading (+)
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imag + c2.imag);
    }

    // Method Overloading
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum (int): " + (a + b));
    }

    public void Add(double a, double b)
    {
        Console.WriteLine("Sum (double): " + (a + b));
    }

    // Display
    public void Display()
    {
        Console.WriteLine("Complex Number: " + real + " + " + imag + "i");
    }
}

// Dynamic Binding Example
class BaseClass
{
    public virtual void Show()
    {
        Console.WriteLine("Animal sound");
    }
}

class DerivedClass : BaseClass
{
    public override void Show()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program by Rahul");

        // Operator Overloading
        Complex c1 = new Complex(3, 4);
        Complex c2 = new Complex(5, 6);

        Complex c3 = c1 + c2;

        c3.Display();

        Console.WriteLine("Result is: " + c3.real + " + " + c3.imag + "i");

        // Dynamic Binding
        BaseClass obj = new DerivedClass();
        obj.Show();

        Console.ReadLine();
    }
}