using System;

namespace CursoFoo_Exercicio3_Minha_Reposta
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalcularImpostoPais calcBrazil = new CalcularImpostoBrazil(1000, 100);
            ICalcularImpostoPais calcUSA = new CalcularImpostoBrazil(1000, 100);
            ICalcularImpostoPais calcArgentina = new CalcularImpostoBrazil(1000, 100);

            CalcularImposto calcular = new CalcularImposto();
            Console.WriteLine($"Brazil {calcular.Calcular(calcBrazil)}");
            Console.WriteLine($"USA {calcular.Calcular(calcUSA)}");
            Console.WriteLine($"Argentina {calcular.Calcular(calcArgentina)}");


            Console.ReadLine();
        }
    }
}
