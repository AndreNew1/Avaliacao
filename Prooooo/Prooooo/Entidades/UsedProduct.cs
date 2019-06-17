using System;
using System.Collections.Generic;
using System.Text;

namespace Prooooo.Entidades
{
    class UsedProduct :Product
    {
         public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string nome, double preco, DateTime date) : base(nome, preco)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name
                + " (used) $"
                + Price
                + " (Manufacture date:"
                + Date
                + ") ";
        }
    }
}
