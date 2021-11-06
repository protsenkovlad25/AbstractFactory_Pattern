using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_AbstractFactory.Foods;
using Cafe_AbstractFactory.Varieties_of_dishes;

namespace Cafe_AbstractFactory.Meals
{
    class Lunch: Menu
    {
        public override Main CreateMain()
        {
            return new Pasta();
        }
        public override Salad CreateSalad()
        {
            return new Vegies();
        }
        public override Dessert CreateDessert()
        {
            return new Biscuit();
        }
        public override Drink CreateDrink()
        {
            return new Compote();
        }
    }
}
