using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        private string descripction = "unknown Beverage";

        //public string description { get; set; }

        /// <summary>
        /// getDescription is already implemented for us
        /// </summary>
        /// <returns></returns>
        public string getDescription()
        {
            return descripction;
        }

        public void setDescription(string description)
        {
            this.descripction = description;
        }

        /// <summary>
        /// we need to implement cost in the subclasses
        /// </summary>
        /// <returns></returns>
        public abstract double cost();
    }
}
