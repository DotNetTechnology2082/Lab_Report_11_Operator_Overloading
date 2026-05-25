using System;

// Base class
class ComplexBase
{
    public int real;
    public int imag;

    public ComplexBase(int r, int i)
    {
        real = r;
        imag = i;
    }

    // Method overloading
    public void Show()
    {
        Console.WriteLine("Base Complex: " + real + " + " + imag + "i");
    }

    public void Show(string message)
    {
        Console.WriteLine(message + " " + real + " + " + imag + "i");
    }

    // Virtual method for dynamic binding
    public virtual void Display()
    {
        Console.WriteLine("Display from Base Class: " + real + " + " + imag + "i");
    }

    // Operator overloading
    public static ComplexBase operator +(ComplexBase c1, ComplexBase c2)
    {
        return new ComplexBase(c1.real + c2.real, c1.imag + c2.imag);
    }
}

// Derived class
class ComplexDerived : ComplexBase
{
    public ComplexDerived(int r, int i) : base(r, i) { }

    // Method overriding
    public override void Display()
    {
        Console.WriteLine("Display from Derived Class: " + real + " + " + imag + "i");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ComplexBase c1 = new ComplexBase(2, 3);
        ComplexBase c2 = new ComplexBase(4, 5);

        // Operator overloading
        ComplexBase c3 = c1 + c2;

        c1.Show("First:");
        c2.Show("Second:");
        c3.Show("Sum:");

        Console.WriteLine("\n--- Method Overriding + Dynamic Binding ---");

        // Dynamic binding (runtime polymorphism)
        ComplexBase obj;

        obj = new ComplexBase(10, 20);
        obj.Display();   // Base version

        obj = new ComplexDerived(30, 40);
        obj.Display();   // Derived version (runtime decision)

        Console.ReadLine();
    }
}