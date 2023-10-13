using System;

namespace Arithmetic
{
    public  class Class1
    {
      

        public static double addition( double x, double y)
        {   

           return x + y;
        }
        public static double substraction(double x, double y)
        {

            return x - y;
        }
        public static double multiplication(double x, double y)
        {

            return x * y;
        }
        public static double division(double x, double y)
        {
            if (y == 0)
            {
                Console.WriteLine("Determinant should not be zero");
                return 0;
            }
            else
            {
                return x / y;
            }
           
        }
        public static double modulus(double x, double y)
        {

            return x % y;
        }
    }
}
