using System;
using System.Collections.Generic;
using System.Text;

namespace Order.OrderItem
{
    class Product
    {
        public string NomeProd { get; set; }
        public double Price { get; set; }


        public Product()
        {

        }
        public Product(string Nome, double preco)
        {
            NomeProd = Nome;
            Price = preco;
        }
    }
}
