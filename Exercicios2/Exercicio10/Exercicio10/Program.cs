using System;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal peixe = new Peixe("Nemo");
            peixe.Mover();

            Animal ave = new Ave("Cegonha");
            ave.Mover();
            Console.ReadLine();
        }
    }
}
