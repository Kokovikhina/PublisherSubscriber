using Easy.MessageHub;
using System;

namespace PubSub
{
    class PubSubMain
    {
        static void Main(string[] args)
        {
            var hub = MessageHub.Instance;
            var shop = new Shop();
            var email = new Email();
            var crm = new Crm();

            email.Subscriber(hub);
            crm.Subscriber(hub);
            shop.Publisher(hub);

            shop.Publish();
            shop.NewCustomer(new Customer(4, "Darya Kokovikhina", "Almaty, Kazakhstan"));

            hub.ClearSubscriptions();
            Console.ReadLine();
        }
    }
}
