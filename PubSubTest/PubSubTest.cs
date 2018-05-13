using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Easy.MessageHub;

namespace PubSubTest
{
    [TestClass]
    public class PubSubTest
    {
        [TestMethod]
        public void Test_PublishToCrm()
        {
            //Arrange
            var hub = MessageHub.Instance;
            var crm = new PubSub.Crm();
            var shop = new PubSub.Shop();
            var expected = "Darya Kokovikhina";
            shop.Publisher(hub);
            crm.Subscriber(hub);

            //Act
            shop.NewCustomer(new PubSub.Customer(4, expected, "Almaty, Kazakhstan"));
            //Assert
            Assert.AreEqual(expected, crm.customerFullName);


        }

        [TestMethod]
        public void Test_PublishToEmail()
        {
            //Arrange
            var hub = MessageHub.Instance;
            var email = new PubSub.Email();
            var shop = new PubSub.Shop();
            var expected = "Darya Kokovikhina";
            shop.Publisher(hub);
            email.Subscriber(hub);

            //Act
            shop.NewCustomer(new PubSub.Customer(4, expected, "Almaty, Kazakhstan"));
            //Assert
            Assert.AreEqual(expected, email.customerFullName);


        }
    }
}
