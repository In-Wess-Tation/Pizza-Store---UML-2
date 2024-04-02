using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Store___UML_2
{
    public class MenuCatalog
    {

      List<Pizza> pizzas = new List<Pizza>();

        public List<Pizza> ThePizzaList { get => pizzas; set => pizzas = value; }

        public void CreatePizza(string name, int price)
        {
            Pizza p = new Pizza(name, price);
            ThePizzaList.Add(p);
        }


        public Pizza GetPizza(string searchWord)
        {
            bool found = false;
            int index = 0;
            Pizza foundPizza = null;
            while (found == false && index <= ThePizzaList.Count - 1)
            {
                if (ThePizzaList[index].Name.Equals(searchWord))
                {
                    found = true;
                    foundPizza = ThePizzaList[index];
                }
                index++;

            }
            if (found == false) throw new PizzaNotFoundException();

            return foundPizza;


            /*        Pizza nameSearch = pizzas.Find(pizza => pizza.Name == searchWord );
                    Console.WriteLine(nameSearch);
                    if(nameSearch == null ) 
                    {
                        Console.WriteLine($"{searchWord} pizza not found");
                    }
                    return nameSearch;*/
        }


        public void UpdatePizza(string name, int price)
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= ThePizzaList.Count - 1)
            {
                if (ThePizzaList[index].Name.Equals(name))
                {
                    found = true;
                    ThePizzaList[index].Price = price;
                }
                index++;

            }
            if (found == false) throw new PizzaNotFoundException();

        }

        public void DeletePizza(string searchWord) 
        {
            bool found = false;
            int index = 0;
            while (found == false && index <= ThePizzaList.Count - 1)
            {
                if (ThePizzaList[index].Name.Equals(searchWord))
                {
                    found = true;
                    ThePizzaList.RemoveAt(index);
                }
                index++;

            }
            if (found == false) throw new PizzaNotFoundException();

            

            /*pizzas.Remove(Delete(searchWord));
            return pizzas[0];*/

        }


        public string PrintMenu()
        {
            string pm = "";
            foreach(Pizza p in ThePizzaList)
            {
                pm = pm + p.ToString();
            }
            return pm;
        }






    }
}
