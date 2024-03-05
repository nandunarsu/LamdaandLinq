using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }

        public Products(int productId,string productName, double price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;

        }
    }
}
