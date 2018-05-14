using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405
{
    class Onibus : MeioTransporte 
    {

        public int Velocidade { get; set; }
        public int Combustivel { get; set; }
        public string Modelo { get; set; }

        // Chave para objeto Marca
        public int MarcaId { get;set; }

        //Propriedade de navegação

        public virtual Marca _Marca { get; set; }

        public Onibus()
        {
            Velocidade = 0;
            Combustivel = 10;
        }

        public void Acelerar()
        {
            Velocidade += 6;
            Combustivel -= 1;
        }

        public void Desacelerar()
        {
            Velocidade -= 3;
        }

        public void NivelCombustivel()
        {
            throw new NotImplementedException();
        }
    }
}
