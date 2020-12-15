using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
namespace DeliverySystem.DataModels
{
    [DataContract]
    class Product
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Producer { get; set; }
        [DataMember]
        public float Price { get; set; }

    }
}
