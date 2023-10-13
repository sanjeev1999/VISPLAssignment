using System;


namespace Power
{
    public class Class1
    {
        public static double Square(double x)
        {

            return x*x;
        }
        public static double Cube(double x)
        {

            return x * x*x;
        }
        public static double SquareRoot(double x)
        {

            if (x >= 0)
                return Math.Sqrt(x);
            else
                throw new ArithmeticException("Cannot calculate square root of a negative number.");
        }
        public static double CubeRoot(double x)
        {

            if (x >= 0)
                return Math.Pow(x, 1.0 / 3.0); 
            else
                throw new ArithmeticException("Cannot calculate cube root of a negative number.");
        }

        public static  double BaseToExponent(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
        public static double BaseToInverseExponent(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, 1.0/ exponent);
        }

    }
}
