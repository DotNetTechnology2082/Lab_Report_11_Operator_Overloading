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
        Console.WriteLine(real + " + " + imag + "i");
    }
}

// Dynamic Binding Example
class BaseClass
{
    public virtual void Show()
    {
        Console.WriteLine("Base Class Method");
    }
}

class DerivedClass : BaseClass
{
    public override void Show()
    {
        Console.WriteLine("Derived Class Method");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Operator Overloading
        Complex c1 = new Complex(6, 2);
        Complex c2 = new Complex(4, 5);

        Complex c3 = c1 + c2;

        Console.WriteLine("Complex Addition:");
        c3.Display();

        // Method Overloading
        c1.Add(10, 20);
        c1.Add(5.5, 2.5);

        // Dynamic Binding
        BaseClass obj = new DerivedClass();
        obj.Show();

        Console.ReadLine();
    }
}
