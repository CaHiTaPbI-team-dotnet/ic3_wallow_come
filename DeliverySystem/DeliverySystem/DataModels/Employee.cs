using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace DeliverySystem.DataModels
{
    [DataContract]
    class Employee
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Sname { get; set; }
        
        [DataMember]
        public decimal salary { get; set; }

        [DataMember]
        public string postion { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Fname}, {Sname}, {salary}, {postion}";
        }
    }
}
