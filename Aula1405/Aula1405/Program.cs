using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405
{
    class Program
    {
        static void Main(string[] args)
        {

            Carro car = new Carro();
            Onibus bus = new Onibus();

            Console.WriteLine("Velocidade inicial do carro:" + car.Velocidade);

            car.Acelerar();
            car.Acelerar();
            car.Desacelerar();
            Console.WriteLine("Velocidade de aceleração do carro:" + car.Velocidade);
            Console.WriteLine("Combustivel  do carro:" + car.Combustivel);
            Console.Write("Velocidade atual do carro e combustivel" + car.Velocidade + car.Combustivel);

            ///////////////////////////////////////////////////////////


            Console.WriteLine("Velocidade inicial do onibus:" + bus.Velocidade);

            bus.Acelerar();
            bus.Acelerar();
            bus.Desacelerar();
            bus.Desacelerar();

            Console.WriteLine("Velocidade de aceleração do onibus:" + bus.Velocidade);

            

            Console.WriteLine("Velocidade atual do Onibus" + bus.Velocidade);



            static void AcelerarBastante(MeioTransporte meioTransporte)
            {
                for (int i = 0; i < 10; i++)
                {
                    meioTransporte.Acelerar();
                }

            }


            Console.ReadKey();


        }

        static void CriarRelacionamentos()
        {
            Carro c = new Carro();

            c.Modelo = "Corsa";


            Carro m = new Carro();
            m.Nome = "Chevrolet";

            c._Marca = m;


            Onibus o = new Onibus();

            o.Modelo = "3100";
            o._Marca = m;


            



           
    


        }
    }
}
