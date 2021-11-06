using System;
using Cafe_AbstractFactory.Varieties_of_dishes;
using Cafe_AbstractFactory.Meals;

namespace Cafe_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сколько времени?");
            int Time = Convert.ToInt32(Console.ReadLine());

            if (Time < 8 || Time >= 23)
                Console.WriteLine("Кафе закрыто");

            if (Time >= 8 && Time < 13)
            {
                Client client = new Client(new Breakfast());
                client.MainFood();
                client.SaladFood();
                client.DessertFood();
                client.DrinkFood();
            }

            if (Time >= 13 && Time < 18)
            {
                Client client = new Client(new Lunch());
                client.MainFood();
                client.SaladFood();
                client.DessertFood();
                client.DrinkFood();
            }

            if (Time >= 18 && Time < 23)
            {
                Client client = new Client(new Supper());
                client.MainFood();
                client.SaladFood();
                client.DessertFood();
                client.DrinkFood();
            }
        }
    }

    class Client
    {
        private Main main;
        private Salad salad;
        private Dessert dessert;
        private Drink drink;

        public Client(Menu menu)
        {
            main = menu.CreateMain();
            salad = menu.CreateSalad();
            dessert = menu.CreateDessert();
            drink = menu.CreateDrink();
        }

        public void MainFood()
        { main.MainFood(); }

        public void SaladFood()
        { salad.SaladFood(); }

        public void DessertFood()
        { dessert.DessertFood(); }

        public void DrinkFood()
        { drink.DrinkFood(); }
    }
}
