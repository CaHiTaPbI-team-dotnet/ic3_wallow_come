using System;
using System.Collections.Generic;
using System.Text;
using DeliverySystem.DataModels;
using DeliverySystem.Repositories;
using System.IO;
using System.Runtime.Serialization.Json;


namespace DeliverySystem.DataManagers
{
    class CRM_Manager
    {
        CRM cRM = new CRM();

        readonly string path = @"..\..\..\DataStorage\";
        DataContractJsonSerializer serializer =
            new DataContractJsonSerializer(typeof(CRM));

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path,FileMode.Open,FileAccess.Write))
            {
                serializer.WriteObject(fs, cRM);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                cRM = (CRM)serializer.ReadObject(fs);
            }
        }

        public void InitData()
        {
            cRM.clients.AddRange(new Client[]
            {
                new Client {ID = 1, Name = "Rikardo", Surnname = "Milos", Phonenumber = "+8855553535", Icq = "1231325", Telegram = "@milos"},
                new Client {ID = 2, Name = "Billy", Surnname = "Herrington", Phonenumber = "+8877553535", Icq = "1421325", Telegram = "@billy"},
                new Client {ID = 3, Name = "Van", Surnname = "Darkholme", Phonenumber = "+8866653535", Icq = "3231387", Telegram = "@van"},
            });
        }

        public void Display()
        {
            Console.WriteLine(cRM);
        }
    }
}
