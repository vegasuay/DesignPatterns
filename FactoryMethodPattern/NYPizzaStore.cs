using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class NYPizzaStore:PizzaStore
    {
        protected override Pizza createPizza(string item)
        {
            Pizza pizza = null;

            //NYStore is composed with NY pizza ingredient factory.
            //this will be used to produce the ingredients for all NY pizzas
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            //for each type of pizza, we instantiete a new pizza and give it the factory it needs to get its ingred.
            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.name = "New York Style cheese pizza";
            }
            else if (item.Equals("clams"))
            {
                pizza = new ClamPizza(ingredientFactory);
                pizza.name = "New York Style clam pizza";
            }
            /* all pizzas 
            else if (item.Equals("veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.name = "New York Style veggie pizza";
            }
            */

            return pizza;
        }
    }
}
