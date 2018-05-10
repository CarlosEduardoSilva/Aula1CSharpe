using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1005
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilizando os construtores parametrizados
            Cliente cli = new Cliente("Jucicreia"); // nome

            Console.WriteLine(cli.Nome1);
            //Console.WriteLine(cli.Cpf1);


            Cliente cli2 = new Cliente("Jucicreia", "123"); // nome, cpf
            cli2.DataNas = new DateTime(1950, 05, 05);
            Console.WriteLine(
                cli2.Nome1 + " nasceu em " + cli2.DataNas
                );
            Console.WriteLine(
                cli2.Nome1 + " nasceu em " + cli2.DataQueNasceu
                );
            Console.WriteLine(
                cli2.Nome1 + " tem " + cli2.Idade
                );


            //Pessoa p = new Pessoa();
            //Classes abstradads não podem ser instanciadas


            Console.ReadLine();



        }
    }
}
