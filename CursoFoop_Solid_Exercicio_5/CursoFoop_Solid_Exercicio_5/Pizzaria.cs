namespace CursoFoop_Solid_Exercicio_5
{
    class Pizzaria : IPizzaria
    {
        private readonly PizzaFactory _factory;
        public Pizzaria(PizzaFactory factory)
        {
            _factory = factory;
        }

        public void CriarPizza(string tipo)
        {
            _factory.CriarPizza(tipo);
        }
    }
}
