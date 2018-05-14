using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005
{
    class Cliente : Pessoa
    {

        public DateTime DataNas { get; set; }

        public string DataQueNasceu
        {
            get
            {
                return DataNas.ToShortDateString();
            }

        }

        public int Idade
        {
            get
            {
                return DateTime.Today.Year - DataNas.Year;               
            }
        }

        public Cliente()
        {
                    
        }

        public Cliente(string nome) : base(nome)
        {
            
        }
        public Cliente(string nome, string cpf) :
            base(nome, cpf)
        {

        }

        override
            public string ImprimirInfo()
        {

            return Nome + ", " + Cpf + ", " +  DataNas.ToShortString();
        }


    }
}
