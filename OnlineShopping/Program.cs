using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Register(new DateTime(2000, 01, 12), "Mary", "Female", "mary123@mail.com", "password");
            customer.Display();
        }
    }
}
