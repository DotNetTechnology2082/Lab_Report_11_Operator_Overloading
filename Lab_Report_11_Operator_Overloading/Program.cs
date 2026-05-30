using System;

namespace LabReport3
{
    class Complex
    {
        // Data members
        public int real;
        public int imag;

        // Constructor
        public Complex(int r = 0, int i = 0)
        {
            real = r;
            imag = i;
        }

        // Operator Overloading (+)
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.real + c2.real, c1.imag + c2.imag);
        }

        // Method Overloading (same method name, different parameters)
        public void Display()
        {
            Console.WriteLine("Complex Number: " + real + " + " + imag + "i");
        }

        public void Display(string message)
        {
            Console.WriteLine(message + " " + real + " + " + imag + "i");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects
            Complex c1 = new Complex(5, 3);
            Complex c2 = new Complex(2, 4);

            // Using overloaded + operator
            Complex c3 = c1 + c2;

            // Method overloading
            c1.Display();
            c2.Display("Second Number:");
            c3.Display("Sum:");

        }
    }
}