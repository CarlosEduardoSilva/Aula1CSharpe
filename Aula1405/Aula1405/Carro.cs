using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405
{
    class Carro : MeioTransporte        
    {

        public int Velocidade { get; set; }


        public int Combustivel { get; set; }


        public string Modelo { get; set; }

        // Chave para objeto Marca
        public int MarcaId { get; set; }

        //Propriedade de navegação

        public virtual Marca _Marca { get; set; }

        public Roda[] Rodas { get; set; }


        public Carro()
        {
            Velocidade = 0;
            Combustivel = 10;
        }

        public void Acelerar()
        {
            Velocidade += 10;
            Combustivel -= 1;
        }

        public void Desacelerar()
        {
            Velocidade -= 5;
        }


        public void NivelCombustivel()
        {
            if(Combustivel <= 0)
            {
                Console.WriteLine("Veiculo sem combustivel");
                
            }

        }
    }
}
