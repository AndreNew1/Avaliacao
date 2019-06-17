using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Order.OrderItem.enums;

namespace Order.OrderItem
{
    class order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> itens { get; set; } = new List<OrderItem>();

        public order()
        {

        }
        public order(DateTime moment,OrderStatus status,Client cliente)
        {
            Moment = moment;
            Status = status;
            Client = cliente;
        }
        public void AddItem(OrderItem item)
        {
            itens.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            itens.Remove(item);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach(OrderItem item in itens)
            {
                sum += item.SuBTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");
            foreach(OrderItem item in itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
