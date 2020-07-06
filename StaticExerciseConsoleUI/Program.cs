using System;

namespace StaticExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temp converter app!");

            Console.WriteLine("Enter a temp in Fahrenheit to convert: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"The temperature in Clesius is: {TempConverter.FahrenheitToCelsius(fahrenheit)}");

            Console.WriteLine("Now enter a temp in Celsius to convert: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The temperature in Fahrenheit is: {TempConverter.CelsiusToFahrenheit(celsius)}");

            Console.WriteLine("Thank you for using our app! Have a great day :)");


            //var celsius = TempConverter.FahrenheitToCelsius(68);
            //Console.WriteLine($"Celsius {celsius}");

            //var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            //Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}
