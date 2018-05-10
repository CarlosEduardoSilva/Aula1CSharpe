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
            Cliente cli = new Cliente();

            cli.Nome1 = "Carlos";
            string nomeCliente = cli.Nome1;
            cli.Cpf1 = "123";
            string cpfCliente = cli.Cpf1;

            Console.WriteLine(cli.Nome1);
            Console.WriteLine(cli.Cpf1);
            Console.ReadLine();



        }
    }
}
