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

        public void ConvertCelsiusToFahrenheit_Added_Non_Integer()
        {
            //ARRANGE
            var temp = new Conversion();
            
            private int temperatureInput

            //ACT


            //ASSERT


        }




        public void ConvertCelsiusToFahrenheit_NegativeInteger_ThrowsException()
        {
            //Arrange
            Conversion temp = new Conversion();
            new Conversion { TemperatureInput = "a"  };
           
            //Act
                         
            bool boolResult = System.Convert.ToBoolean((temp.ConvertCelciusToFahrenheit()));                     

            //Assert
            Assert.That(boolResult, Is.True);

        }                

    }
}
