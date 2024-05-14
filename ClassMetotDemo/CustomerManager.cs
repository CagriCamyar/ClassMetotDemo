using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add (Customer customer)
        {
            Console.WriteLine("Eklenen Müşteri : " + customer.Name + " " + customer.Surname);
        }

        public void Remove (Customer customer) 
        {
            Console.WriteLine("Silinen Müşteri : " + customer.Name + " " + customer.Surname);
        }
    }
}