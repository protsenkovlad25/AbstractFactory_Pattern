using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cafe_AbstractFactory.Varieties_of_dishes;

namespace Cafe_AbstractFactory.Foods
{
    class Vegies: Salad
    {
        public override void SaladFood()
        {
            Console.WriteLine("Vegies");
        }
    }
}
