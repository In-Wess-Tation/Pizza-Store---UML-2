using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class PizzaNotFoundException : Exception 
    {
        public PizzaNotFoundException() : base ("Pizza not found")
        {

        }

        public PizzaNotFoundException(string Message) : base(Message)
        {

        }


    }
}
