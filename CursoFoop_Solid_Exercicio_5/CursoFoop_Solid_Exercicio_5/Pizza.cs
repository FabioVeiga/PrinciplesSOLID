using System;

namespace CursoFoop_Solid_Exercicio_5
{
    public abstract class Pizza
    {
        public string Tipo { get; set; }

        public Pizza(string tipo)
        {
            if (string.IsNullOrEmpty(tipo))
                throw new ArgumentException("Nome não pode ser nulo ou vazio@");

            Tipo = tipo;
        }

        public abstract int AssarPizza();
        public void DeliveryPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Tipo}");
        }

    }
}
