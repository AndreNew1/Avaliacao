using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Prooooo.Entidades
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string nome,double preco)
        {
            Name = nome;
            Price = preco;

        }

        public virtual string PriceTag()
        {
            return Name
                + " $ "
                + Price.ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
