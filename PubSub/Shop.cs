using Easy.MessageHub;
using System;
using System.Collections.Generic;
using System.Text;

namespace PubSub
{
    public class Shop
    {
        private IMessageHub _hub;

        public void Publisher(IMessageHub hub)
        {
            _hub = hub;
        }

        public void Publish()
        {
            _hub.Publish(new Customer(1, "Bred Pitt", "12 Bukit Jalil, Kuala Lumpur, Malaysia"));
            _hub.Publish(new Order(1, "iPhone"));
        }

        public void NewCustomer(Customer customer)
        {
            _hub.Publish(customer);
        }

        public void NewOrder(Order order)
        {
            _hub.Publish(order);
        }
    }
}
