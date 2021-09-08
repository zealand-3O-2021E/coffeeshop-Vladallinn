using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte : Coffee, IMilk
    {
        
        public Latte(int discount, string name) : base(discount, name)
        {
            Discount = discount;
            Name = name;
        }

        public int mlMilk()
        {
            return 200;
        }

        public override int price()
        {
            return 40 - Discount;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
