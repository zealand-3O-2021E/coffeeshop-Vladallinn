using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee : Coffee
    {
        
        public BlackCoffee(int discount, string name) : base(discount, name)
        {
            Discount = discount;
            Name = name;
        }

        public override string Strength()
        {
            return "Strong";
        }
        
    }
}
