using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f_1 = new Fraction();
        Console.WriteLine(f_1.GetString());
        Console.WriteLine(f_1.GetDigit());

        Fraction f_2 = new Fraction(5);
        Console.WriteLine(f_2.GetString());
        Console.WriteLine(f_2.GetDigit());

        Fraction f_3 = new Fraction(3,4);
        Console.WriteLine(f_3.GetString());
        Console.WriteLine(f_3.GetDigit());

        Fraction f_4 = new Fraction(1,3);
        Console.WriteLine(f_4.GetString());
        Console.WriteLine(f_4.GetDigit());
    }
}