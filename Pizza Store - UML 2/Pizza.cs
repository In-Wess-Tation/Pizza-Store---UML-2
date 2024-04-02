using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizza_Store___UML_2
{
    public class Pizza
    {

        public string Name { get; set; }
/*        public Topping Toppings { get; set; }*/
        public int Price { get; set; }


        public Pizza(string name,/* Topping toppings,*/ int price)
        {
            Name = name;
 /*           Toppings = toppings;*/
            Price = price;
        }

        public override string ToString()
        {
            return "Pizza's name is " + Name + " The price is " + Price + " " + Environment.NewLine /*+ Toppings + " as toppings"*/ ;
        }

    }
}
