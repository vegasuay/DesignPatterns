using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //first create the weatherdata object
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay cd = new CurrentConditionsDisplay(weatherData);
            //StatisticsDisplay
            //ForecastDisplay

            //simulate new weather measurements
            weatherData.setMeasurements(60, 65, 40);
            weatherData.setMeasurements(70, 45, 30);
            weatherData.setMeasurements(80, 65, 48);
        }
    }
}
