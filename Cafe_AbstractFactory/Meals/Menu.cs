using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_AbstractFactory.Varieties_of_dishes;

namespace Cafe_AbstractFactory.Meals
{
    abstract class Menu
    {
        public abstract Main CreateMain();
        public abstract Salad CreateSalad();
        public abstract Dessert CreateDessert();
        public abstract Drink CreateDrink();
    }
}
