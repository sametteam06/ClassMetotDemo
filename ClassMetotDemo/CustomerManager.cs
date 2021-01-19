using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            customer.IsActive = true;
            Console.WriteLine(customer.Name + " isimli müşteri eklendi.");
            Console.WriteLine("-----------------------");
        }
        public void ShowAll(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                if (customer.IsActive == true)
                {
                    Console.WriteLine("Müşteri Adı : " + customer.Name);
                    Console.WriteLine("Müşteri Adı : " + customer.Surname);
                    Console.WriteLine("-----------------------");
                }
            }
        }
        public void Delete(Customer customer)
        {
            customer.IsActive = false;
            Console.WriteLine(customer.Name + " isimli müşteri silindi.");
            Console.WriteLine("-----------------------");
        }
    }
}

