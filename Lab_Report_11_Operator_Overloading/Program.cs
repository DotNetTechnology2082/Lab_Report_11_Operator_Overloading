using System;

class Complex
{
    // Data members
    int real, imag;

    // Constructor
    public Complex(int r, int i)
    {
        real = r;
        imag = i;
    }

    // Operator Overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real,
                           c1.imag + c2.imag);
    }

    // Method Overloading
    public void Show()
    {
        Console.WriteLine("Complex Number: " + real + " + " + imag + "i");
    }

    public void Show(string message)
    {
        Console.WriteLine(message + ": " + real + " + " + imag + "i");
    }

    // Virtual method for Dynamic Binding
    public virtual void Display()
    {
        Console.WriteLine("Display from Base Class");
    }
}

// Derived class
class DerivedComplex : Complex
{
    public DerivedComplex(int r, int i) : base(r, i)
    {
    }

    // Overriding method
    public override void Display()
    {
        Console.WriteLine("Display from Derived Class");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating objects
        Complex c1 = new Complex(1, 3);
        Complex c2 = new Complex(2, 6);

        // Using overloaded + operator
        Complex c3 = c1 + c2;

        // Display result
        c3.Show();

        // Calling overloaded methods
        c3.Show("Result after Addition");

        // Dynamic Binding
        Complex obj = new DerivedComplex(1, 2);
        obj.Display();

        Console.ReadLine();
    }
}
