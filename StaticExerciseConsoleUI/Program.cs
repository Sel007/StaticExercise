using System;

namespace StaticExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temp converter app!");

            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Celsius {celsius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }
    }
}
