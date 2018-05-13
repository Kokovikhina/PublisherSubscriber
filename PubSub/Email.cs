using System;
using System.Collections.Generic;
using System.Text;
using Easy.MessageHub;

namespace PubSub
{
    public class Email
    {
        private IMessageHub _hub;
        private Guid _subscriptionTokenOnNewOrder;
        private Guid _subscriptionTokenOnNewCustomer;
        public string customerFullName;

        public void Subscriber(IMessageHub hub)
        {
            _hub = hub;
            _subscriptionTokenOnNewOrder = _hub.Subscribe<Order>(OnNewOrder);
            _subscriptionTokenOnNewCustomer = _hub.Subscribe<Customer>(OnNewCustomer);
        }

        public void UnSubscribe()
        {
            _hub.UnSubscribe(_subscriptionTokenOnNewOrder);
            _hub.UnSubscribe(_subscriptionTokenOnNewCustomer);
        }

        private void OnNewOrder(Order order)
        {
            Console.WriteLine("Send email New order:");
            Console.Write(order.ItemName);
            Console.WriteLine();
        }

        private void OnNewCustomer(Customer customer)
        {

            Console.WriteLine("Send email New customer:");
            Console.Write(customer.FullName);
            this.customerFullName = customer.FullName;
            Console.WriteLine();
        }
    }
}
