using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mikolaj.Samulak.Service1.Tests
{
    class WeatherForecastTests
    {
        [Fact]
        public void Generate_Test()
        {
            var weatherForecast = new WeatherForecast { TemperatureC = -20 };

            var result = weatherForecast.TemperatureF;


            if (weatherForecast.TemperatureC <= -40)
            {
                Assert.False(result > weatherForecast.TemperatureC);
            }
            else
            {
                Assert.True(result > weatherForecast.TemperatureC);
            }

        }
    }
}
