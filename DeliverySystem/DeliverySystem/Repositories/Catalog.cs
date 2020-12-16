using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using DeliverySystem.DataModels;
namespace DeliverySystem.Repositories
{
    [DataContract]
    class Catalog
    {
        [DataMember]
        public List<Product> Products { get; set; } = new List<Product>();

        public override string ToString()
        {
            string res = "";
            foreach(Product p in Products)
            {
                res += $"  {p.ID}. {p.Name}  \"{p.Producer}\"  -> {p.Price} \n";
            }
            return res;
        }
    }
}
