namespace Pizza_Store___UML_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuCatalog menu = new MenuCatalog();

            Console.WriteLine("Pizza Menu: ");

            menu.CreatePizza("Magarita", 70);
            menu.CreatePizza("Vulvato", 80);
            menu.CreatePizza("Ham", 80);
            menu.CreatePizza("Bacon", 60);
            menu.CreatePizza("Chicken", 80);
            menu.CreatePizza("Fish", 65);
            Console.WriteLine(menu.PrintMenu());

            
            try
            {
               Pizza p = menu.GetPizza("Magarita");
                Console.WriteLine("Pizza searched: ");
                Console.WriteLine(p.ToString());
            }
            catch (PizzaNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            menu.DeletePizza("Ham");
            Console.WriteLine("");
            Console.WriteLine("Updated pizza Manu with deleted item: ");
            Console.WriteLine(menu.PrintMenu());
          


            menu.UpdatePizza("Vulvato", 120);
            Console.WriteLine("Updated pizza menu with updated price: ");
            Console.Write(menu.PrintMenu());






            Customers customerList = new Customers();

            Console.WriteLine("");
            Console.WriteLine("Customer List: ");

            customerList.CreateCustomer("Matilde", "Æbletoft 52", 52525252);
            customerList.CreateCustomer("Frederik", "Svendeborg 25", 80808080);
            customerList.CreateCustomer("Inge", "Frederikberg 36", 45454545);
            customerList.CreateCustomer("Weslyn", "Rampelysey", 55555555);
            customerList.CreateCustomer("Camilla", "Ølstykke", 65656565);
            customerList.CreateCustomer("Kasper", "Holbækvej 12", 20202020);
            Console.WriteLine(customerList.PrintCustomerList());


            try
            {
                Customer c = customerList.GetCustomer("Matilde");
                Console.WriteLine("Customer searched: ");
                Console.WriteLine(c.ToString());
            }
            catch (CustomerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            customerList.DeleteCustomer("Inge");
            Console.WriteLine("");
            Console.WriteLine("Updated customer lidt with deleted customer: ");
            Console.WriteLine(customerList.PrintCustomerList());


            customerList.UpdateCustomer("Frederik", "Svendeborg 25", 12003245);
            Console.WriteLine("Updated customer list with updated address and/or phonenumber: ");
            Console.Write(customerList.PrintCustomerList());





            OrderCatalog orderList = new OrderCatalog();

            Console.WriteLine("");
            Console.WriteLine("Order List: ");

            orderList.CreateOrder(customerList.TheCustomerList[1], menu.ThePizzaList[0], 0);
            orderList.CreateOrder(customerList.TheCustomerList[0], menu.ThePizzaList[1], 1);
            orderList.CreateOrder(customerList.TheCustomerList[3], menu.ThePizzaList[0], 2);
            orderList.CreateOrder(customerList.TheCustomerList[4], menu.ThePizzaList[4], 3);

            Console.WriteLine(orderList.PrintOrderList());



            try
            {
                Order o = orderList.GetOrder(0);
                Console.WriteLine("Order searched: ");
                Console.WriteLine(o.ToString());
            }
            catch (CustomerNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            orderList.DeleteOrder(3);
            Console.WriteLine("");
            Console.WriteLine("Updated order lidt with deleted order: ");
            Console.WriteLine(orderList.PrintOrderList());


            orderList.UpdateOrder(customerList.TheCustomerList[3], menu.ThePizzaList[1], 2);
            Console.WriteLine("Updated order list with updated customer, pizza or ID: ");
            Console.Write(orderList.PrintOrderList());



        }
    }
}
