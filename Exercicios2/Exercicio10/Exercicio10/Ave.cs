using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio10
{
    class Ave : Animal
    {
        public Ave(string tipo) : base(tipo) { }

        public override void Mover()
        {
            Console.WriteLine($"{Tipo} está voando!");

        }
    }
}