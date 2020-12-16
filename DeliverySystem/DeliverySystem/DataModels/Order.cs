using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DeliverySystem.DataModels
{
    [DataContract]
    class Order
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public List<Product> products { get; set; } = new List<Product>();
        [DataMember]
        public string BuyerFName { get; set; }

        public override string ToString()
        {
            return $"{ID,15},{products,15},{BuyerFName,15}";
        }

    }
}
