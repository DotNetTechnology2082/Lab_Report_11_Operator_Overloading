using System;

class Complex
{
    int real;
    int imaginary;

    // Constructor
    public Complex(int real, int imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    // Operator Overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real,
                           c1.imaginary + c2.imaginary);
    }

    // Method Overloading
    public void Display()
    {
        Console.WriteLine("Complex Number: " + real + " + " + imaginary + "i");
    }

    public void Display(string message)
    {
        Console.WriteLine(message + " " + real + " + " + imaginary + "i");
    }
}

// Dynamic Binding Example
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program by Pradip Prajapati");

        // Creating objects
        Complex c1 = new Complex(2, 6);
        Complex c2 = new Complex(3, 5);

        // Using overloaded + operator
        Complex c3 = c1 + c2;

        // Calling overloaded methods
        c3.Display();
        c3.Display("Result is:");

        // Dynamic Binding
        Animal a = new Dog();
        a.Sound();

        Console.ReadLine();
    }
}