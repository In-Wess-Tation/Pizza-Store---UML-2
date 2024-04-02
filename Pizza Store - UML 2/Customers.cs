using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class Customers
    {

        List<Customer> customers = new List<Customer>();

        public List<Customer> TheCustomerList { get => customers; set => customers = value; }

        public void CreateCustomer(string name, string address, int phoneNumber)
        {
            Customer c = new Customer(name, address, phoneNumber);
            TheCustomerList.Add(c);
        }


        public Customer GetCustomer(string searchWord)
        {
            bool found = false;
            int index = 0;
            Customer foundCustomer = null;
            while (found == false && index <= TheCustomerList.Count - 1)
            {
                if (TheCustomerList[index].Name.Equals(searchWord))
                {
                    found = true;
                    foundCustomer = TheCustomerList[index];
                }
                index++;

            }
            if (found == false) throw new CustomerNotFoundException();

            return foundCustomer;


            /*        Pizza nameSearch = pizzas.Find(pizza => pizza.Name == searchWord );
                    Console.WriteLine(nameSearch);
                    if(nameSearch == null ) 
                    {
                        Console.WriteLine($"{searchWord} pizza not found");
                    }
                    return nameSearch;*/
        }


        public void UpdateCustomer(string name, string address, int phoneNumber)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= TheCustomerList.Count - 1)
            {
                if (TheCustomerList[index].Name.Equals(name))
                {
                    found = true;
                    TheCustomerList[index].Address = address;
                    TheCustomerList[index].PhoneNumber = phoneNumber;
                }
                index++;

            }
            if (found == false) throw new CustomerNotFoundException();

        }

        public void DeleteCustomer(string searchWord)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= TheCustomerList.Count - 1)
            {
                if (TheCustomerList[index].Name.Equals(searchWord))
                {
                    found = true;
                    TheCustomerList.RemoveAt(index);
                }
                index++;

            }
            if (found == false) throw new CustomerNotFoundException();

        }


        public string PrintCustomerList()
        {
            string cl = "";
            foreach (Customer c in TheCustomerList)
            {
                cl = cl + c.ToString();
            }
            return cl;
        }









    }
}
