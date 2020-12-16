using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace DeliverySystem.DataModels
{
    [DataContract]
    class Client
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surnname { get; set; }

        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string Phonenumber { get; set; }

        [DataMember]
        public string Icq { get; set; }

        [DataMember]
        public string Telegram { get; set; }

        public override string ToString()
        {
            return $"{Name,15}{Surnname,15}{ID,15}{Phonenumber,15}{Icq,15}{Telegram,15}";
        }
    }
}
