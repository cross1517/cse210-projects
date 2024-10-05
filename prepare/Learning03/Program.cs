using System;



class Program
{
    static void Main(string[] args)
    {
        void DisplayGetSet()
        {
            Fraction fraction1 = new Fraction();
            Console.WriteLine(fraction1.GetNumerator());
            Console.WriteLine(fraction1.GetDenominator());

            Fraction fraction = new Fraction(1, 2);
            Console.WriteLine(fraction.GetNumerator());
            Console.WriteLine(fraction.GetDenominator());

            Fraction fraction3 = new Fraction(3);
            Console.WriteLine(fraction3.GetNumerator());
            Console.WriteLine(fraction3.GetDenominator());

            fraction.SetNumerator(4);
            fraction.SetDenominator(5);
            Console.WriteLine(fraction.GetNumerator());
            Console.WriteLine(fraction.GetDenominator());
        };

        DisplayGetSet();

        void DisplayFractionString()
        {
            Fraction fraction = new Fraction(3, 4);
            Console.WriteLine(fraction.GetFractionString());

            Fraction fraction2 = new Fraction(5);
            Console.WriteLine(fraction2.GetFractionString());

            Fraction fraction3 = new Fraction();
            Console.WriteLine(fraction3.GetFractionString());

            Fraction fraction4 = new Fraction(1, 3);
            Console.WriteLine(fraction4.GetFractionString());
        }

        void DisplayDecimalValue()
        {
            Fraction fraction = new Fraction(3, 4);
            Console.WriteLine(fraction.GetDecimalValue());

            Fraction fraction2 = new Fraction(5);
            Console.WriteLine(fraction2.GetDecimalValue());

            Fraction fraction3 = new Fraction();
            Console.WriteLine(fraction3.GetDecimalValue());

            Fraction fraction4 = new Fraction(1, 3);
            Console.WriteLine(fraction4.GetDecimalValue());
        }

        DisplayFractionString();

        DisplayDecimalValue();



    }
}