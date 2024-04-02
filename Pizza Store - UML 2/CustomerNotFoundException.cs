using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class CustomerNotFoundException : Exception
    {

        public CustomerNotFoundException() : base("Customer not found")
        {

        }

        public CustomerNotFoundException(string Message) : base(Message)
        {

        }



    }
}
