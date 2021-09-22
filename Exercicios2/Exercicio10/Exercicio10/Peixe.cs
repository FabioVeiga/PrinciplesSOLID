using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10
{
    class Peixe : Animal
    {
        public Peixe(string tipo) : base(tipo) { }

        public override void Mover()
        {
            Console.WriteLine($"{Tipo} está nadando!");
        }
    }
}
