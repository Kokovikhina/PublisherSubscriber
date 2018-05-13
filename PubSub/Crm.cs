using Easy.MessageHub;
using System;
using System.Collections.Generic;
using System.Text;

namespace PubSub
{
    public class Crm
    {
        private IMessageHub _hub;
        private Guid _subscriptionToken;
        public string customerFullName;

        public void Subscriber(IMessageHub hub)
        {
            _hub = hub;
            _subscriptionToken = _hub.Subscribe<Customer>(OnNewCustomer);
        }

        public void UnSubscribe()
        {
            _hub.UnSubscribe(_subscriptionToken);
        }

        public void OnNewCustomer(Customer customer)
        {
            Console.WriteLine("Save New customer to follow up:");
            Console.Write(customer.FullName);
            this.customerFullName = customer.FullName;
            Console.WriteLine();
        }
    }
}
