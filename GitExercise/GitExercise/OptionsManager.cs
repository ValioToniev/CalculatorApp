using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
<<<<<<< HEAD
<<<<<<< HEAD
            "d - Division",
            "sabs - SubtractAbs"
=======
            "dr - Divide Remainder",
            "ex - Exit"
>>>>>>> Dev-B
=======
            "pow - Power",
            "log - Logarithm",
            "fact - Sum of 2 factorials"
>>>>>>> Dev-C
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }

<<<<<<< HEAD
<<<<<<< HEAD
        public static void Divison(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }

        public static void SubtractAbs(double a, double b)
        {
            Console.WriteLine($"|{a}-{b}| = {Math.Abs(a-b)}");
        }


=======
        public static void DivideRemainder(double a, double b)
        {
            Console.WriteLine($"{a} % {b} = {a % b}");
        }
>>>>>>> Dev-B
=======
        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
        }

        public static void Log(double a, double b)
        {
            Console.WriteLine($"Log of {a} with base {b} = {Math.Log(a, b)}");
        }

        public static void Factorial(double a, double b)
        {
            long factA = CalculateFact((int)a);
            long factB = CalculateFact((int)b);
            Console.WriteLine($"{(int)a}! + {(int)b}! = {factA} + {factB} = {factA + factB}");
        }

        private static long CalculateFact(int a)
        {
            long result = a;
            for (int i = a - 1; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }



>>>>>>> Dev-C
    }
}
