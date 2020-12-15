using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using DeliverySystem.DataModels;

namespace DeliverySystem.Repositories
{
    [DataContract]
    class Company
    {
        [DataMember]
        public List<Employee> employees { get; set; } = new List<Employee>();

        public void Display()
        {
            foreach (Employee e in employees)
                Console.WriteLine(e);
        }
    }
}
