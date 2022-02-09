using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Prog8170Assign2.Tests
{
    [TestFixture]
    public class ConversionTest
    {
        [Test]
        public void ConvertCelsiusToFahrenheit_Min_Integer() //Boundary value analysis min value on a -50 degree thermometer
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -50;

            //ACT
            temp.ConvertCelciusToFahrenheit();

            //ASSERT
            Assert.AreEqual(-58, temp.ConvertCelciusToFahrenheit());
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_MinPlus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -49;

            //ACT
            temp.ConvertCelciusToFahrenheit();

            //ASSERT
            Assert.AreEqual(-56, temp.ConvertCelciusToFahrenheit());
        }
        [Test]
        public void ConvertCelsiusToFahrenheit_Nominal_Integer()//Boundary value analysis Nominal Value on -50 - 50 degree celsius thermometer
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;            

            //ACT
            temp.ConvertCelciusToFahrenheit();

            //ASSERT
            Assert.AreEqual(32, temp.ConvertCelciusToFahrenheit());
        }

        [Test]
        public void ConvertCelsiusToKelvin_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -273;

            //ACT
            temp.ConvertCelciusToKelvin();

            //ASSERT
            Assert.AreEqual(0, temp.ConvertCelciusToKelvin());
        }

        [Test]
        public void ConvertCelsiusToKelvin_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -272;

            //ACT
            temp.ConvertCelciusToKelvin();

            //ASSERT
            Assert.AreEqual(1, temp.ConvertCelciusToKelvin());
        }

        [Test]
        public void ConvertCelsiusToKelvin_Adding_Integer()//Nominal freezing point of water
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertCelciusToKelvin();

            //ASSERT
            Assert.AreEqual(273, temp.ConvertCelciusToKelvin());
        }

        [Test]
        public void ConvertFahrenheitToCelsius_Min_Added_Integer() //Boundary value analysis min value for fahrenheit in a 50 C thermometer
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -58;

            //ACT
            temp.ConvertFahrenheitToCelsius();

            //ASSERT
            Assert.AreEqual(-50, temp.ConvertFahrenheitToCelsius());
        }

        [Test]
        public void ConvertFahrenheitToCelsius_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -57;

            //ACT
            temp.ConvertFahrenheitToCelsius();

            //ASSERT
            Assert.AreEqual(-49, temp.ConvertFahrenheitToCelsius());
        }

        [Test]
        public void ConvertFahrenheitToCelsius_Adding_Integer()//Boundary value analysis freezing temperature
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 32;

            //ACT
            temp.ConvertFahrenheitToCelsius();

            //ASSERT
            Assert.AreEqual(0, temp.ConvertFahrenheitToCelsius());
        }

        [Test]
        public void ConvertFahrenheitToKelvin_Min_Added_Integer() //Boundary value analysis min value on 50 degree C thermometer
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -58;

            //ACT
            temp.ConvertFahrenheitToKelvin();

            //ASSERT
            Assert.AreEqual(223, temp.ConvertFahrenheitToKelvin());
        }

        [Test]
        public void ConvertFahrenheitToKelvin_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = -39;

            //ACT
            temp.ConvertFahrenheitToKelvin();

            //ASSERT
            Assert.AreEqual(234, temp.ConvertFahrenheitToKelvin());
        }

        [Test]
        public void ConvertFahrenheitToKelvin_Adding_Integer()//Boundary value analysis nominal water freezing point
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 32;

            //ACT
            temp.ConvertFahrenheitToKelvin();

            //ASSERT
            Assert.AreEqual(273, temp.ConvertFahrenheitToKelvin());
        }
        [Test]
        public void ConvertKelvinToCelsius_Min_Added_Integer() //Boundary value analysis min value lowest possible temp
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertKelvinToCelsius();

            //ASSERT
            Assert.AreEqual(-273, temp.ConvertKelvinToCelsius());
        }

        [Test]
        public void ConvertKelvinToCelsius_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertKelvinToCelsius();

            //ASSERT
            Assert.AreEqual(-272, temp.ConvertKelvinToCelsius());
        }

        [Test]
        public void ConvertKelvinToCelsius_Adding_Integer()//Boundary value analysis water freezing point
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 273;

            //ACT
            temp.ConvertKelvinToCelsius();

            //ASSERT
            Assert.AreEqual(0, temp.ConvertKelvinToCelsius());
        }
        [Test]
        public void ConvertKelvinToFahrenheit_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertKelvinToFahrenheit();

            //ASSERT
            Assert.AreEqual(-460, temp.ConvertKelvinToFahrenheit());
        }

        [Test]
        public void ConvertKelvinToFahrenheit_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertKelvinToFahrenheit();

            //ASSERT
            Assert.AreEqual(-458, temp.ConvertKelvinToFahrenheit());
        }

        [Test]
        public void ConvertKelvinToFahrenheit_Adding_Integer()//Boundary value analysis freezing point of water
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 273;

            //ACT
            temp.ConvertKelvinToFahrenheit();

            //ASSERT
            Assert.AreEqual(32, temp.ConvertKelvinToFahrenheit());
        }
    }
}




