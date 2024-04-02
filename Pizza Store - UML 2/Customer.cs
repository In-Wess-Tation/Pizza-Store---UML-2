using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }


        public Customer(string name, string address, int phoneNumber)
        {
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return "Customer name is " + Name + ", their address is " + Address + " and their phone number is " + PhoneNumber + Environment.NewLine;
        }




    }
}
