﻿using System;
using System.Runtime.CompilerServices;

namespace GitExercise
{
    public class Startup
    {
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain access: ");
            string password = Console.ReadLine();
            Console.Clear();
            return password == Password;
        }

        private const string Password = "abcd1234";
        public static void Main()
        {
<<<<<<< HEAD
            bool isAuthorized = CheckCredentials();
            if (isAuthorized)
            {
                Console.WriteLine("Access denied!");
                Console.ReadKey(intercept:true);
                return;

            }
            

            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));
=======
            while (true)
            {
                Console.WriteLine("Console Calculator App");
                Console.WriteLine(new string('-', 15));
>>>>>>> Dev-B

                Console.Write("a = ");
                double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.Write("b = ");
                double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

                Console.WriteLine("Choose one from the listed options:");
                foreach (string option in OptionsManager.OptionsList)
                {
                    Console.WriteLine($"\t{option}");
                }

                Console.Write("Option: ");
                string choice = Console.ReadLine();

<<<<<<< HEAD
            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
                case "d":
                    OptionsManager.Divison(a, b);
                    break;
                case "sabs":
                    OptionsManager.SubtractAbs(a, b);
                    break;

                  
            }

            Console.WriteLine("Press any key to close the app...");
            Console.ReadKey(true);
=======
                switch (choice)
                {
                    case "a":
                        OptionsManager.Add(a, b);
                        break;
                    case "s":
                        OptionsManager.Subtract(a, b);
                        break;
                    case "m":
                        OptionsManager.Multiply(a, b);
                        break;
                    case "dr":
                        OptionsManager.DivideRemainder(a, b);
                        break;
                    case "ex":
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        Console.ReadKey(true);
                        return;
                }

                Console.WriteLine("Pres any key to close the app...");
                Console.ReadKey(true);
            }
>>>>>>> Dev-B
        }
    }
}
