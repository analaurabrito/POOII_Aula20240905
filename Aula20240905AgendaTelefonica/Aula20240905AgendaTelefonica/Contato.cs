using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20240905AgendaTelefonica
{
    internal class Contato
    {
        public string Nome;
        public string Telefone;
        public string Tipo;

        public Contato(string nome, string telefone, string tipo)
        {
            Nome = nome;
            Telefone = telefone;
            Tipo = tipo;
        }
    }
}
