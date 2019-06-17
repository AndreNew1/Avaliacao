using System;
using System.Collections.Generic;
using System.Text;

namespace Prooooo.Entidades
{
    class ImportedProduct : Product
    {
        public double customsFee { get; set; }


        public ImportedProduct()
        {
        }
        public ImportedProduct(string nome, double preco, double custo) : base(nome, preco)
        {
            customsFee = custo;
        }
        public double totalPrice()
        {
            return customsFee + Price;
        }

        public override string PriceTag()
        {
            return Name
                + " $ "
                + totalPrice()
                + " (Customs fee:"
                + customsFee
                + ")";
        }
    }
}
