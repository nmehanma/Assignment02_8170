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
        public void ConvertCelsiusToFahrenheit_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertCelciusToFahrenheit();

            //ASSERT
            Assert.AreEqual(33, temp.ConvertCelciusToFahrenheit());
        }

        [Test]
        public void ConvertCelsiusToFahrenheit_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 2;

            //ACT
            temp.ConvertCelciusToFahrenheit();

            //ASSERT
            Assert.AreEqual(35, temp.ConvertCelciusToFahrenheit());

        }
        [Test]
        public void ConvertCelsiusToFahrenheit_Adding_Integer()//Boundary value analysis just below min value which should be invalid
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
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertCelciusToKelvin();

            //ASSERT
            Assert.AreEqual(274.15, temp.ConvertCelciusToKelvin());
        }

        [Test]
        public void ConvertCelsiusToKelvin_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 2;

            //ACT
            temp.ConvertCelciusToKelvin();

            //ASSERT
            Assert.AreEqual(275.15, temp.ConvertCelciusToKelvin());
        }

        [Test]
        public void ConvertCelsiusToKelvin_Adding_Integer()//Boundary value analysis just below min value which should be invalid
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertCelciusToKelvin();

            //ASSERT
            Assert.AreEqual(273.15, temp.ConvertCelciusToKelvin());
        }

        [Test]
        public void ConvertFahrenheitToCelsius_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertFahrenheitToCelsius();

            //ASSERT
            Assert.AreEqual(-17, temp.ConvertFahrenheitToCelsius());
        }

        [Test]
        public void ConvertFahrenheitToCelsius_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 2;

            //ACT
            temp.ConvertFahrenheitToCelsius();

            //ASSERT
            Assert.AreEqual(-16.7, temp.ConvertFahrenheitToCelsius());
        }

        [Test]
        public void ConvertFahrenheitToCelsius_Adding_Integer()//Boundary value analysis just below min value which should be invalid
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertFahrenheitToCelsius();

            //ASSERT
            Assert.AreEqual(-17, temp.ConvertFahrenheitToCelsius());
        }

        [Test]
        public void ConvertFahrenheitToKelvin_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertFahrenheitToKelvin();

            //ASSERT
            Assert.AreEqual(255, temp.ConvertFahrenheitToKelvin());
        }

        [Test]
        public void ConvertFahrenheitToKelvin_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 2;

            //ACT
            temp.ConvertFahrenheitToKelvin();

            //ASSERT
            Assert.AreEqual(256, temp.ConvertFahrenheitToKelvin());
        }

        [Test]
        public void ConvertFahrenheitToKelvin_Adding_Integer()//Boundary value analysis just below min value which should be invalid
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertFahrenheitToKelvin();

            //ASSERT
            Assert.AreEqual(255.37, temp.ConvertFahrenheitToKelvin());
        }
        [Test]
        public void ConvertKelvinToCelsius_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertKelvinToCelsius();

            //ASSERT
            Assert.AreEqual(-272.15, temp.ConvertKelvinToCelsius());
        }

        [Test]
        public void ConvertKelvinToCelsius_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 2;

            //ACT
            temp.ConvertKelvinToCelsius();

            //ASSERT
            Assert.AreEqual(-271.15, temp.ConvertKelvinToCelsius());
        }

        [Test]
        public void ConvertKelvinToCelsius_Adding_Integer()//Boundary value analysis just below min value which should be invalid
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertKelvinToCelsius();

            //ASSERT
            Assert.AreEqual(-273.15, temp.ConvertKelvinToCelsius());
        }
        [Test]
        public void ConvertKelvinToFahrenheit_Min_Added_Integer() //Boundary value analysis min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 1;

            //ACT
            temp.ConvertKelvinToFahrenheit();

            //ASSERT
            Assert.AreEqual(-457, temp.ConvertKelvinToFahrenheit());
        }

        [Test]
        public void ConvertKelvinToFahrenheit_Min_plus1_Added_Integer()//Boundary value analysis just above min value
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 2;

            //ACT
            temp.ConvertKelvinToFahrenheit();

            //ASSERT
            Assert.AreEqual(-456, temp.ConvertKelvinToFahrenheit());
        }

        [Test]
        public void ConvertKelvinToFahrenheit_Adding_Integer()//Boundary value analysis just below min value which should be invalid
        {
            //ARRANGE
            Conversion temp = new Conversion();
            temp.TemperatureInput = 0;

            //ACT
            temp.ConvertKelvinToFahrenheit();

            //ASSERT
            Assert.AreEqual(-459, temp.ConvertKelvinToFahrenheit());
        }
    }
}




