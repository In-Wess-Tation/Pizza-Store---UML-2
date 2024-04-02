using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class OrderCatalog
    {


        List<Order> orders = new List<Order>();


        public void CreateOrder(Customer customer, Pizza pizza, int id)
        {
            Order o = new Order(customer, pizza, id);
            orders.Add(o);
        }


        public Order GetOrder(int searchWord)
        {
            bool found = false;
            int index = 0;
            Order foundOrder = null;
            while (found == false && index <= orders.Count - 1)
            {
                if (orders[index].Id.Equals(searchWord))
                {
                    found = true;
                    foundOrder = orders[index];
                }
                index++;

            }
            if (found == false) throw new OrderNotFoundException();

            return foundOrder;


            /*        Pizza nameSearch = pizzas.Find(pizza => pizza.Name == searchWord );
                    Console.WriteLine(nameSearch);
                    if(nameSearch == null ) 
                    {
                        Console.WriteLine($"{searchWord} pizza not found");
                    }
                    return nameSearch;*/
        }


        public void UpdateOrder(Customer customer, Pizza pizza, int id)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= orders.Count - 1)
            {
                if (orders[index].Id.Equals(id))
                {
                    found = true;
                    orders[index].Customer = customer;
                    orders[index].Pizza = pizza;
                }
                index++;

            }
            if (found == false) throw new OrderNotFoundException();

        }

        public void DeleteOrder(int searchWord)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= orders.Count - 1)
            {
                if (orders[index].Id.Equals(searchWord))
                {
                    found = true;
                    orders.RemoveAt(index);
                }
                index++;

            }
            if (found == false) throw new OrderNotFoundException();

        }


        public string PrintOrderList()
        {
            string ol = "";
            foreach (Order o in orders)
            {
                ol = ol + o.ToString();
            }
            return ol;
        }





    }
}
