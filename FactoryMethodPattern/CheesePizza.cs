using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class CheesePizza:Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        /// <summary>
        /// to make a pizza now, we need a factory to provide the ingredients. so each pizza
        /// class gets a factory passed into its constructor, and it's stored in an instance variable.
        /// </summary>
        /// <param name="ingredientFactory"></param>
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        /// <summary>
        /// the prepare method steps through creating a cheese pizza, and each time it
        /// needs an ingredient, it asks the factory to produce it.
        /// </summary>
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }
}
