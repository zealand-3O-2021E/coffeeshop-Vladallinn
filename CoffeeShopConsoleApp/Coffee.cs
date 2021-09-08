using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    /// <summary>
    /// A class that is used for coffe orders
    /// </summary>
    public abstract class Coffee
    {
        public int Discount { get; set; }
        public string Name { get; set; }

        public Coffee(int discount, string name)
        {
            Discount = discount;
            Name = name;
        }
        public abstract string Strength();
        /// <summary>
        /// returns the price of the coffee
        /// It's possible to override this method, beacuse it is virtual 
        /// </summary>
        /// <returns>20 dkr</returns>
        public virtual int price()
        {
            if(Discount > 5)
            {
                throw new ArgumentException("The discount can not be more than 5 kr");
            }
            return 20 - Discount;
        }

    }
}
