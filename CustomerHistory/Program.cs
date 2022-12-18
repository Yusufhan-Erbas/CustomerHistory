// See https://aka.ms/new-console-template for more information

using CustomerHistory;

Customer customer1= new Customer();
customer1.CustomerName = "David";
customer1.CustomerSurname = "Smith";
customer1.Nationality = "England";
customer1.BirthDate = new DateTime(1978,12,2);
Customer customer2= new Customer();
customer2.CustomerName = "Ali";
customer2.CustomerSurname = "Ekinci";
customer2.Nationality = "Turkey";
customer2.BirthDate = new DateTime(1995, 7, 25);
Customer customer3= new Customer();
customer3.CustomerName = "Jack";
customer3.CustomerSurname = "Woods";
customer3.Nationality = "Australia";
customer3.BirthDate = new DateTime(1965, 6, 3);

CustomerManager manager= new CustomerManager();
manager.AddCustomer(customer1);
manager.DeleteCustomer(customer1);
manager.AddCustomer(customer2);
manager.DeleteCustomer(customer2);
manager.AddCustomer(customer3);
manager.DeleteCustomer(customer3);

Customer[] customers = new Customer[] {customer1,customer2,customer3 };
manager.ListCustomer(customers);

