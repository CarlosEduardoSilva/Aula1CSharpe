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
            Cliente cli2 = new Cliente("Jucicreia", "123"); // nome, cpf
            


            Console.WriteLine(cli.Nome1);
            Console.WriteLine(cli.Cpf1);
            Console.ReadLine();



        }
    }
}
