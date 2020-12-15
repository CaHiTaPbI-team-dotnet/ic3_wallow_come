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
    }
}
