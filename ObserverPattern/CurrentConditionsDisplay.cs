using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElemt
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        
        /// <summary>
        /// the constructor is passed the weatherData object and we use it to register
        /// </summary>
        /// <param name="weatherData"></param>
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);            
        }

        /// <summary>
        /// just prints out the most recent temp and humidity
        /// </summary>
        public void display()
        {
            Console.Write("current condition: " + temperature + " degrees and " + humidity + " % humidity");
        }

        /// <summary>
        /// when update is called, we save the temp and humi and call display
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;

        }
    }
}
