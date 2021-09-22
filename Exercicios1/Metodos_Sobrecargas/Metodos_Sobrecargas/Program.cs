using System;

namespace Metodos_Sobrecargas
{
    class Program
    {
        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static public double Somar(double numero1, int numero2)
        {
            return numero1 + numero2;
        }
        static public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }
        static public double Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach(int num in numeros)
            {
                resultado += num;
            }
            return resultado;
        }
        //parametros opcionais
        static public int Somar(int x, int y = 20, int w = 30, int z = 40)
        {
            return x + w + z + y;
        }
        static void Main(string[] args)
        {
            var resultado1 = Somar(1, 2);
            var resultado2 = Program.Somar(1, 2, 3);
            var resultado3 = Somar(new int[] {1,2,3,4 });
            var resultado4 = Somar(1, 2, 3, 4);


        }
    }
}
