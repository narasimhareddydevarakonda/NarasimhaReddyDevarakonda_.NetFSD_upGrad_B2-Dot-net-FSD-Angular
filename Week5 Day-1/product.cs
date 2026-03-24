using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week5_Day_1
{
    class Product
    {
        public string Name { get; set; }

        
        private double price;

  
        public double Price
        {
            get { return price; }
            protected set
            {
                if (value > 0)
                    price = value;
            }
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

      
        public virtual double CalculateDiscount()
        {
            return Price;
        }
    }

    class Electronics : Product
    {
        public Electronics(string name, double price) : base(name, price) { }

        public override double CalculateDiscount()
        {
            return Price - (Price * 0.05); // 5% discount
        }
    }

    
    class Clothing : Product
    {
        public Clothing(string name, double price) : base(name, price) { }

        public override double CalculateDiscount()
        {
            return Price - (Price * 0.15); // 15% discount
        }
    }
}
