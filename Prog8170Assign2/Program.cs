using System;

namespace Prog8170Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            Conversion temperatureConverter = new Conversion();
            Console.WriteLine("Please enter the value to be converted, it must be an integer greater than zero.");


            var num1 = Console.ReadLine();
            var num2 = validateIntegerType(num1);       
                      
            temperatureConverter.TemperatureInput = Int32.Parse(num2);

            validTemp(temperatureConverter.TemperatureInput);

            var userSelection = Console.ReadLine();

            var newNumber = validateUserSelection(userSelection);
           
            switch (newNumber)
            {
                case 1:
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToFahrenheit()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine($"{temperatureConverter.ConvertCelciusToKelvin()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine($"{temperatureConverter.ConvertFahrenheitToCelsius()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.WriteLine($"{temperatureConverter.ConvertFahrenheitToKelvin()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine($"{temperatureConverter.ConvertKelvinToCelsius()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine($"{temperatureConverter.ConvertKelvinToFahrenheit()}");
                    Console.WriteLine("Press Any Key to Quit");
                    Console.ReadKey();
                    break;
                case 7:                    
                    return;               
            }
        }
        public static string validateIntegerType(String input)
        {           
            int numericValue;
            bool isNumber = int.TryParse(input, out numericValue);
            if (isNumber != true || int.Parse(input) < 1)
            {
                Console.WriteLine("Please enter an integer value greater than 0");
            }
            else
            {
                return input;                 
            }
            return validateIntegerType(Console.ReadLine());
        }         
        public static string  validTemp(int number)
        {
                Console.WriteLine("Please select one of the 7 options to convert your input:");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
                return Convert.ToString(number);                                                                                    
        }
        public static int validateUserSelection(String number)
        {
            int numericValue;
            bool isNumber = int.TryParse(number, out numericValue);
            if (isNumber != true)
            {
                Console.WriteLine("Please select one of the 7 options to convert your input:");
                Console.WriteLine("1. Convert Celsius to Fahrenheit");
                Console.WriteLine("2. Convert Celsius to Kelvin");
                Console.WriteLine("3. Convert Fahrenheit to Celsius");
                Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                Console.WriteLine("5. Convert Kelvin to Celsius");
                Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                Console.WriteLine("7. Exit");
            }
            else
            {
                var number2 = Int32.Parse(number);
                if (number2 != 1 && number2 != 2 && number2 != 3 && number2 != 4 && number2 != 5 && number2 != 6 && number2 != 7)
                {
                    Console.WriteLine("Please select one of the 7 options to convert your input:");
                    Console.WriteLine("1. Convert Celsius to Fahrenheit");
                    Console.WriteLine("2. Convert Celsius to Kelvin");
                    Console.WriteLine("3. Convert Fahrenheit to Celsius");
                    Console.WriteLine("4. Convert Fahrenheit to Kelvin");
                    Console.WriteLine("5. Convert Kelvin to Celsius");
                    Console.WriteLine("6. Convert Kelvin to Fahrenheit");
                    Console.WriteLine("7. Exit");
                }
                else
                {
                    return number2;
                }
            }                                      
            return validateUserSelection(Console.ReadLine());
        }
    }
}
