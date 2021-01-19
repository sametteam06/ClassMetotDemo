using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Name1";
            customer1.Surname = "Surname1";

            Customer customer2 = new Customer();
            customer2.Name = "Name2";
            customer2.Surname = "Surname2";

            Customer customer3 = new Customer();
            customer3.Name = "Name3";
            customer3.Surname = "Surname3";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(customer1); //customer1 eklendi ve ekrana ismi yazıldı.

            customerManager.ShowAll(customers); //eklenen müşteriler listelendi (sadece customer1 listelenir).

            customerManager.Add(customer2); //customer2 eklendi.

            customerManager.ShowAll(customers); //eklenen müşteriler listelendi (customer1 ve costomer2 listelenir).

            customerManager.Add(customer3); //customer3 eklendi.

            customerManager.ShowAll(customers); //eklenen müşteriler listelendi (customer1, customer2 ve customer3 listelenir).
        }
    }
}
