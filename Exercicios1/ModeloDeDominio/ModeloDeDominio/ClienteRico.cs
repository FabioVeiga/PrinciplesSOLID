using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDeDominio
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            DomainExceptionValidation.When(id < 0, "Id menor que zero!");
            //if (id < 0)
            //    throw new InvalidOperationException();
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "Nome não pode ser nulo!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "Endereço não pode ser nulo!");

            //if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
            //    throw new InvalidOperationException();

            Id = id;
            Nome = nome;
            Endereco = endereco;
        }
    }
}
