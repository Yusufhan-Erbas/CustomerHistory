using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerHistory
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added " + customer.CustomerName);            
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer deleted " + customer.CustomerName);          
        }
        public  void ListCustomer(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer "+customer.CustomerName);
            }
                                
        }
    }
}
