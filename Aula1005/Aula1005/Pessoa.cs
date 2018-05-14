using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005
{
    class Pessoa
    {
        private string Nome;
        private string Cpf;

        public string Nome1 { get => Nome; set => Nome = value; }
        public string Cpf1 { get => Cpf; set => Cpf = value; }

        public Pessoa()
        {

        }
        public Pessoa(String nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string cpf)
        {

            Nome = nome;
            Cpf = cpf;

        }


        
    }
}
