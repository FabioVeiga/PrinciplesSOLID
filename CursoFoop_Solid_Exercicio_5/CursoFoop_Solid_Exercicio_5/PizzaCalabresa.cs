using System;

namespace CursoFoop_Solid_Exercicio_5
{
    class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa(string tipo) : base(tipo){}
        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Tipo}" +
                $" por {tempo} minutos");
            return tempo;
        }
    }
}
