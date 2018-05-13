using System;
using System.Collections.Generic;
using System.Text;

namespace PubSub
{
    public class Customer
    {
        private int id;
        private string fullName;
        private string address;

        public Customer(int id, string fullName, string address)
        {
            this.id = id;
            this.fullName = fullName;
            this.address = address;
        }

        public int Id { get=>id; set=>id=value; }
        public string FullName { get=>fullName; set=>fullName=value; }
        public string Address { get=>address; set=>address=value; }
        
    }
}
