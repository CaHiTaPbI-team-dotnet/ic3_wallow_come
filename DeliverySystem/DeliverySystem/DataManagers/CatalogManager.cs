using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using DeliverySystem.Repositories;
using DeliverySystem.DataModels;
using System.IO;
namespace DeliverySystem.DataManagers
{
    class CatalogManager
    {
        Catalog catalog = new Catalog();
        string path = @"..\..\..\DataStorage\goods.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Catalog));
        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, catalog);
            }
        }
        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                catalog = (Catalog)serializer.ReadObject(fs);
            }
        }
        public void InitData()
        {
            catalog.Products.AddRange(new Product[] { 
                new Product() { ID = 1, Name = "Бургер", Price = 20.99F, Producer = "МакДоналдс" },
                new Product() { ID = 2, Name = "Дабл Чизбургер", Price = 25.99F, Producer = "МакДоналдс" },
                new Product() { ID = 3, Name = "Картошка фри", Price = 13.99F, Producer = "ФОП \"Картопля від Баби Мані\"" },
                new Product() { ID = 4, Name = "МакНагетси", Price = 31.99F, Producer = "МакДоналдс" },
                new Product() { ID = 5, Name = "Кола", Price = 9.99F, Producer = "Кока Кола Inc." },
            });
        }
        public void Display()
        {
            Console.WriteLine(catalog);
        }
    }
}
