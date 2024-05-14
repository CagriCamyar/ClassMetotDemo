using System;

namespace ClassMetotDemo
{

    class Program
    {

        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Çağrı";
            customer1.Surname = "Çamyar";
            customer1.Address = "Kartal";
            customer1.City = "Ordu";
            customer1.Note = 1348;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Onur";
            customer2.Surname = "Dursun";
            customer2.Address = "Pendik";
            customer2.City = "Giresun";
            customer2.Note = 1642;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Tufan";
            customer3.Surname = "Öztürk";
            customer3.Address = "Çınardere";
            customer3.City = "Sinop";
            customer3.Note = 1535;

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Fatih Burak";
            customer4.Surname = "Pehlivan";
            customer4.Address = "Atalar";
            customer4.City = "Erzurum";
            customer4.Note = 1892;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine(customers[i].Id + ") " + customers[i].Name + " " + customers[i].Surname + " " + customers[i].Address + " " + customers[i].City + " " + customers[i].Note );
            }

            Console.WriteLine();

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + ") " + customer.Name + " " + customer.Surname + " " + customer.Address + " " + customer.City + " " + customer.Note);
            }

            Console.WriteLine();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer2);
            customerManager.Remove(customer3);
        }
    }
}