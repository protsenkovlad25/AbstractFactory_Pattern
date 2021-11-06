using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_AbstractFactory.Foods;
using Cafe_AbstractFactory.Varieties_of_dishes;

namespace Cafe_AbstractFactory.Meals
{
    class Breakfast: Menu
    {
        public override Main CreateMain()
        {
            return new Porridge();
        }
        public override Salad CreateSalad()
        {
            return new Eggs();
        }
        public override Dessert CreateDessert()
        {
            return new Pancake();
        }
        public override Drink CreateDrink()
        {
            return new Coffee();
        }
    }
}
