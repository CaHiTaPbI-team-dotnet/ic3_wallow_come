using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using DeliverySystem.DataModels;

namespace DeliverySystem.Repositories
{
    [DataContract]
    class CRM
    {
        [DataMember]
        public List<Client> clients = new List<Client>();

        [DataMember]
        public List<Order> orders = new List<Order>();

        public void DisplayClients()
        {
            foreach(Client c in clients)
            {
                Console.WriteLine(c);
            }
        }

        public void DisplayOrders()
        {
            foreach(Order o in orders)
            {
                Console.WriteLine(o);
            }
        }

    }
}
