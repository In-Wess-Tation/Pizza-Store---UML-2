using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizza_Store___UML_2
{
    public class Order 
    {

        public Customer Customer { get; set; }
        public Pizza Pizza { get; set; }
        public int Id { get; set; }

   /*     private double _totalPrice;

        public double TotalPrice
        {
            get
            {
                return _totalPrice * 1.25;
            }
            set
            {
                _totalPrice = value;
            }
        }*/

        public Order(Customer customer, Pizza pizza, int id)
        {
            Customer = customer;
            Pizza = pizza;
            Id = id;
/*            TotalPrice = 0;*/
        }

        public override string ToString()
        {
            return "" +  Customer + Pizza + "The Order ID is: " + Id + Environment.NewLine;
        }


    }
}
