using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog8170Assign2
{
    public class Conversion
    {

        //properties 
        private int temperatureInput; //field

        //default constructor
        public Conversion()
        {
            this.temperatureInput = 1;
        }

        //non default construtor

        public int TemperatureInput
        {
            get { return temperatureInput; }
            set { temperatureInput = value; }
        }

                             
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
            return  (double) Decimal.Round((decimal)((this.temperatureInput - 273.15) * 9 / 5 + 32));
        }
        public double ConvertKelvinToCelsius()
        {
            return this.temperatureInput - 273.15;
        }
        public double ConvertFahrenheitToKelvin()
        {
            return (double) Decimal.Round((decimal)((this.temperatureInput - 32) * 5 / 9 + 273.15)); 
        }
        public double ConvertFahrenheitToCelsius()
        {
            return (double) Decimal.Round((this.temperatureInput - 32) * 5 / 9);
        }       
    }

}

