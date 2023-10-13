

using System;

namespace scientifiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

        while (true)
            {
               
                Console.WriteLine("### Scientific Calculator #####");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Square");
                Console.WriteLine("7. Cube");
                Console.WriteLine("8. Square Root");
                Console.WriteLine("9. Cube Root");
                Console.WriteLine("10. X^Y");
                Console.WriteLine("11. X^1/Y");
                Console.WriteLine("12. for Exit");

                double firstNum = 0;
                double secondNum = 0;
                double num = 0;
                double baseNum = 0;
                double Exponent = 0;




                Console.WriteLine("Enter choice");
                String choice = Console.ReadLine();

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")
                {
                    Console.WriteLine("enter first number");
                    firstNum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter second Number");
                    secondNum = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "6" || choice == "7" || choice == "8" || choice == "9")
                {
                    Console.WriteLine("enter number");
                    num = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "10" || choice == "11")
                {
                    Console.WriteLine("enter base number number");
                    baseNum = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the exponent");
                    Exponent = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "12")
                {
                    Console.WriteLine("Exiting....... Thank you");
                    break;
                }


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Sum: " + Arithmetic.Class1.addition(firstNum, secondNum));

                        break;
                    case "2":
                        Console.WriteLine("Substraction: " + Arithmetic.Class1.substraction(firstNum, secondNum));
                        break;
                    case "3":
                        Console.WriteLine("Multiplication: " + Arithmetic.Class1.multiplication(firstNum, secondNum));
                        break;
                    case "4":
                        Console.WriteLine("Division: " + Arithmetic.Class1.division(firstNum, secondNum));
                        break;
                    case "5":
                        Console.WriteLine("Modulus: " + Arithmetic.Class1.modulus(firstNum, secondNum));
                        break;
                    case "6":
                        Console.WriteLine("Square: " + Power.Class1.Square(num));
                        break;
                    case "7":
                        Console.WriteLine("Cube: " + Power.Class1.Cube(num));
                        break;
                    case "8":
                        Console.WriteLine("Square Root: " + Power.Class1.SquareRoot(num));
                        break;
                    case "9":
                        Console.WriteLine("Cube Root: " + Power.Class1.CubeRoot(num));
                        break;
                    case "10":
                        Console.WriteLine(":X^Y " + Power.Class1.BaseToExponent(baseNum, Exponent));
                        break;
                    case "11":
                        Console.WriteLine(":X^1/Y " + Power.Class1.BaseToInverseExponent(baseNum, Exponent));
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }

          


        }
    }
}
