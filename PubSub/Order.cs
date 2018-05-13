using System;
using System.Collections.Generic;
using System.Text;

namespace PubSub
{
    public class Order
    {
        private int orderNumber;
        private string itemName;

        public Order(int orderNumber, string itemName)
        {
            this.orderNumber = orderNumber;
            this.itemName = itemName;
        }
        public int OrderNumber { get=>orderNumber; set=>orderNumber=value; }
        public string ItemName { get=>itemName; set=>itemName=value; }

    }
}
