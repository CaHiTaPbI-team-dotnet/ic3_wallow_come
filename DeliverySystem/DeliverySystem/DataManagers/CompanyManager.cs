using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using DeliverySystem.Repositories;
using System.IO;
using DeliverySystem.DataModels;

namespace DeliverySystem.DataManagers
{
    class CompanyManager
    {
        Company company = new Company();
        string path = @"..\..\..\DataStorage\employees.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Company));

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, company);
            }
        }
        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                company = (Company)serializer.ReadObject(fs);
            }
        }
        public void InitData()
        {
            company.employees.AddRange(new Employee[]
            {
                new Employee() {ID = 1, Fname = "Bogdan", Sname =  "Lenin", postion = "Design", salary = 0.5M},
                new Employee() {ID = 2, Fname = "Stepan", Sname =  "Pepega", postion = "Sysadmin", salary = 700M},
                new Employee() {ID = 3, Fname = "Oleg", Sname =  "Maket", postion = "Seller", salary = 750M},
                new Employee() {ID = 4, Fname = "Jora", Sname =  "Joskiy", postion = "Manager", salary = 800M},
                new Employee() {ID = 5, Fname = "Petr", Sname =  "Reshala", postion = "Manager", salary = 800M},
           });
        }

        public void AddEmployee()
        {
            Employee buf = new Employee();

            Console.Write("Enter first name:");
            buf.Fname = Console.ReadLine();

            Console.Write("\nEnter second name:");
            buf.Sname = Console.ReadLine();

            Console.Write("\nEnter position name:");
            buf.postion = Console.ReadLine();

            Console.Write("\nEnter ID name:");
            buf.ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter salary name:");
            buf.salary = Convert.ToDecimal(Console.ReadLine());
        }

        public void FireEmployee()
        {
            int buff;

            company.Display();
            Console.Write("\nEnter ID of the employee to delete:");
            buff = Int32.Parse(Console.ReadLine());


            foreach (Employee e in company.employees)
            {
                if (e.ID == buff)
                    company.employees.Remove(e);
                else
                    Console.WriteLine("No such ID found");
            }
        }

        public void AddSalary()
        {
            company.Display();

            int buff;
            Console.Write("\nEnter ID of the employee to rise salary:");
            buff = Int32.Parse(Console.ReadLine());

            decimal bonus;
            Console.Write("\nEnter bonus to salary:");
            bonus = Decimal.Parse(Console.ReadLine());

            foreach (Employee e in company.employees)
            {
                if (e.ID == buff)
                    e.salary = e.salary + bonus;
                else
                    Console.WriteLine("No such ID found");
            }
        }

        public void RemovePremia()
        {
            decimal notbonus;
            Console.Write("\nEnter decrease of salary:");
            notbonus = Decimal.Parse(Console.ReadLine());

            foreach (Employee e in company.employees)
            {
                e.salary = e.salary - notbonus;
            }
        }
    }
}
