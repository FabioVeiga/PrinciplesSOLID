namespace ConsoleApp1
{
    class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public void Identificar()
        {
            System.Console.WriteLine($"Olá {Nome}, sua idade é {Idade} e seu genero é {Sexo}");
        }

    }
}
