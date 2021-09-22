using System;
using System.Collections.Generic;
using System.Text;

namespace CursoFoop_Solid_Exercicio_5
{

    class PizzaFactory
    {
        public Pizza CriarPizza(string sabor)
        {
            Pizza pizza = null;
            switch (sabor.ToLower())
            {
                case "mussarela":
                    pizza = new PizzaMussarela(sabor.ToLower());
                    break;
                case "calabresa":
                    pizza = new PizzaCalabresa(sabor.ToLower());
                    break;
                default:
                    throw new ArgumentNullException("Pizza não existe");
            }
            return pizza;
        }
    }
}
