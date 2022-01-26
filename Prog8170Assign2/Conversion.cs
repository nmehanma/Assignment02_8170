using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170Assign2
{
    public class Conversion
    {
        //private static int x = 1;
        //nothing inside of round brackets mean default constructor
        public Conversion()
        {
            this.temperatureInput = 1;
        }
        
        //non default constructor
        public Conversion(int temp)
        {
            this.temperatureInput = temp;            
        }

        private int temperatureInput;
       
        public double ConvertCelciusToFahrenheit()
        {
            return (this.temperatureInput * 9 / 5) + 32;
        }
        public double ConvertCelciusToKelvin()
        {
            return (this.temperatureInput + 273.15);
        }
        public double ConvertKelvinToFahrenheit()
        {
            return (this.temperatureInput - 273.15) * 9 / 5 + 32;
        }
        public double ConvertKelvinToCelsius()
        {
            return this.temperatureInput - 273.15;
        }
        public double ConvertFahrenheitToKelvin()
        {
            return (this.temperatureInput - 32) * 5 / 9 + 273.15; 
        }
        public double ConvertFahrenheitToCelsius()
        {
            return (this.temperatureInput - 32) * 5 / 9;
        }       
    }
}
