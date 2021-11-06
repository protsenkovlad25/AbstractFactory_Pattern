using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_AbstractFactory.Foods;
using Cafe_AbstractFactory.Varieties_of_dishes;

namespace Cafe_AbstractFactory.Meals
{
    class Supper: Menu
    {
        public override Main CreateMain()
        {
            return new Yogurt();
        }
        public override Salad CreateSalad()
        {
            return new Fruit();
        }
        public override Dessert CreateDessert()
        {
            return new Cake();
        }
        public override Drink CreateDrink()
        {
            return new Tea();
        }
    }
}
