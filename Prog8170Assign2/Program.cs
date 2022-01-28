using System;

namespace Prog8170Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion temperatureConverter = new Conversion();
            Console.WriteLine("Please enter the value to be converted, it must be an integer greater than zero.");

            temperatureConverter.TemperatureInput = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Please select one of the 7 options to convert your input:");
            Console.WriteLine("1. Convert Celsius to Fahrenheit");
            Console.WriteLine("2. Convert Celsius to Kelvin");
            Console.WriteLine("3. Convert Fahrenheit to Celsius");
            Console.WriteLine("4. Convert Fahrenheit to Kelvin");
            Console.WriteLine("5. Convert Kelvin to Celsius");
            Console.WriteLine("6. Convert Kelvin to Fahrenheit");
            Console.WriteLine("7. Exit");
            
            string userSelection = Console.ReadLine();                       

            switch (userSelection)
            {
                case "1":
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToFahrenheit()}");
                    break;
                case "2":
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToKelvin()}");
                    break;
                case "3":
                    Console.WriteLine($"{temperatureConverter.ConvertFahrenheitToCelsius()}");
                    break;
                case "4":
                    Console.WriteLine($"{temperatureConverter.ConvertKelvinToCelsius()}");
                    break;
                case "5":
                    Console.WriteLine($"{temperatureConverter.ConvertKelvinToFahrenheit()}");
                    break;
                case "6":
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToFahrenheit()}");
                    break;
                case "7":                    
                    return;
                    

            }
        }
    }
}
