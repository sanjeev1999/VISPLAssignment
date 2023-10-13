using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class operators
    {
        
        public static void optr()
        {
            // Arithmetic operators
            int a = 10, b = 20;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"Arithmetic Operators:\nSum: {sum}, Difference: {difference}, Product: {product}, Quotient: {quotient}, Remainder: {remainder}");

            // Relational operators
            bool isEqual = a == b;
            bool isNotEqual = a != b;
            bool isGreaterThan = a > b;
            bool isLessThan = a < b;
            bool isGreaterOrEqual = a >= b;
            bool isLessOrEqual = a <= b;

            Console.WriteLine($"\nRelational Operators:\nEqual: {isEqual}, Not Equal: {isNotEqual}, Greater Than: {isGreaterThan}, Less Than: {isLessThan}, Greater or Equal: {isGreaterOrEqual}, Less or Equal: {isLessOrEqual}");

            // Logical operators
            bool condition1 = true, condition2 = false;
            bool logicalAnd = condition1 && condition2;
            bool logicalOr = condition1 || condition2;
            bool logicalNot = !condition1;

            Console.WriteLine($"\nLogical Operators:\nLogical AND: {logicalAnd}, Logical OR: {logicalOr}, Logical NOT: {logicalNot}");

            // Bitwise operators
            int binaryA = 0b1100; // Binary representation of 12
            int binaryB = 0b1010; // Binary representation of 10
            int bitwiseAnd = binaryA & binaryB;
            int bitwiseOr = binaryA | binaryB;
            int bitwiseXor = binaryA ^ binaryB;
            int bitwiseNot = ~binaryA;

            Console.WriteLine($"\nBitwise Operators:\nBitwise AND: {bitwiseAnd}, Bitwise OR: {bitwiseOr}, Bitwise XOR: {bitwiseXor}, Bitwise NOT: {bitwiseNot}");

            //  Ternary Operator
            int x = 5, y = 10;
            int max = (x > y) ? x : y;

            Console.WriteLine($"\nConditional (Ternary) Operator:\nMax value: {max}");
        }
    }


}

