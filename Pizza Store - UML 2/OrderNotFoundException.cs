using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class OrderNotFoundException : Exception
    {


        public OrderNotFoundException() : base("Order not found")
        {

        }

        public OrderNotFoundException(string Message) : base(Message)
        {

        }



    }
}
