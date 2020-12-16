using System;
using System.Collections.Generic;
using System.Text;

namespace DeliverySystem.UI_Controllers
{
    class MenuController
    {
        int choice;
        DialogsController dc = new DialogsController();
        public void DisplayMenu()
        {
            do
            {
                Console.WriteLine("\n> Hello user! Please, input who are you:");
                Console.WriteLine(" 1. Employees Module");
                Console.WriteLine(" 2. Client  Module");
                Console.WriteLine(" 3. Product  Module");
                Console.WriteLine(" 0. Exit");
                GetChoice();
                switch (choice)
                {
                    case 1:
                        DisplayEmployeeMenu();
                        break;
                    case 2:
                        DisplayClientMenu();
                        break;
                    case 3:
                        DisplayProductMenu();
                        break;
                }

    
            } while (AllowContinue());
        }

        public void DisplayEmployeeMenu()
        {
            do { 
                Console.WriteLine("Choose your action:  ");
                Console.WriteLine(" 1. Add employee");
                Console.WriteLine(" 2. Delete Employee");
                Console.WriteLine(" 3. Change Salary");
                Console.WriteLine(" 4. Award");
                Console.WriteLine(" 0. Exit");
                GetChoice();
                switch (choice)
                {
                    case 1:
                        dc.AddEmployee();
                        break;
                    case 2:
                        dc.DelEmployee();
                        break;
                    case 3:
                        dc.ChangeSalaryEmployee();
                        break;
                    case 4:
                        dc.AwardCompany();
                        break;
                }
            } while (AllowContinue());
        }

        public void DisplayClientMenu()
        {
            do { 
                Console.WriteLine("Choose your action:  ");
                Console.WriteLine(" 1. Create Order");
                Console.WriteLine(" 2. Display current order");
                Console.WriteLine(" 3. Add product");
                Console.WriteLine(" 4. Complete order");
                Console.WriteLine(" 0. Exit");
                GetChoice();
                switch (choice)
                {
                    case 1:
                        dc.CreateOrder();
                        break;
                    case 2:
                        dc.DisplayOrder(); 
                        break;
                    case 3:
                        dc.AddProductToOrder();
                        break;
                    case 4:
                        dc.CompleteOrder();
                        break;
                }
            } while (AllowContinue());
        }

        public void DisplayProductMenu()
        {
            do { 
                Console.WriteLine("Choose your action:  ");
                Console.WriteLine(" 1. Add Product       ");
                Console.WriteLine(" 2. Delete Product    ");
                Console.WriteLine(" 3. Change Product    ");
                Console.WriteLine(" 0. Exit ");
                GetChoice();
                switch (choice)
                {
                    case 1:
                        dc.AddProduct();
                        break;
                    case 2:
                        dc.DelProduct();
                        break;
                    case 3:
                        dc.ChangeProduct();
                        break;
                }
            } while (AllowContinue());
        }

        private void GetChoice()
        {
            choice = Convert.ToInt32(Console.ReadLine());
        }
        private bool AllowContinue()
        {
            Console.WriteLine("\n> Do you want continue? (y/n)");
           char ans = Convert.ToChar(Console.ReadLine());
            if (ans == 'y')
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
