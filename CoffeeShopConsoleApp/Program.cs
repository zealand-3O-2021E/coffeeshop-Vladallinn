using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
                new BlackCoffee(5,"Black Coffee"),
                new Latte(5, "Latte"),
                new Cortado(5, "Cortado")

            };


            foreach (var coffee in orderList)
            {
                Console.WriteLine("The Name of the coffee is : " + coffee.Name);
                Console.WriteLine("The Price of the coffee is : "+ coffee.price());
                Console.WriteLine("The Strength for the coffee: " + coffee.Strength());
                Console.WriteLine("===================================================");
            }


        }
    }
}
