using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderQueue
{
    internal class Order
    {
        public int OrderId { get; set; }

        public int OrderQuantity { get; set; }

        public Order(int id,int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        public  void ProcessOrder()
        {
            //print the message
            Console.WriteLine($"Order {OrderId} Processed ! ");
        }
    }
}
