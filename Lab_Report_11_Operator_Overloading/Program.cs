using System;

class Complex
{
    int real, imaginary;

    // Constructor
    public Complex(int r, int i)
    {
        real = r;
        imaginary = i;
    }

    // Operator Overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(
            c1.real + c2.real,
            c1.imaginary + c2.imaginary
        );
    }

    // Method Overloading
    public void Display()
    {
        Console.WriteLine("Complex Number: " + real + " + " + imaginary + "i");
    }

    public void Display(string msg)
    {
        Console.WriteLine(msg + ": " + real + " + " + imaginary + "i");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex(2, 3);
        Complex c2 = new Complex(4, 5);

        Complex c3 = c1 + c2;

        c3.Display();
        c3.Display("Result by Namrata");

        Console.ReadLine();
    }
}