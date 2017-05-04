using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;
        
        public WeatherData()
        {
            observers = new ArrayList();
        } 

        /// <summary>
        /// tell all the observers about the state. all observer implements update
        /// </summary>
        /// <param name="o"></param>
        public void notifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        /// <summary>
        /// when a observer registers, we just add it to the end of the list
        /// </summary>
        /// <param name="o"></param>
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// when a observer wants to un-register, we just take it off the list
        /// </summary>
        /// <param name="o"></param>
        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.Remove(o);
        }

        public void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature,float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;

            measurementsChanged();
        }
    }
}
