using Aula1705.Controllers;
using Aula1705.Models;
using System;

namespace Aula1705.Views {
    class AtividadesView {

        public void ExibirMenu() {

            Console.WriteLine("=========================");
            Console.WriteLine("= Escolha uma opção     =");
            Console.WriteLine("= 1) Criar Atividades   =");
            Console.WriteLine("= 2) Listar Atividades  =");
            Console.WriteLine("= 3) Buscar Atividade   =");
            Console.WriteLine("= 4) Editar Atividade   =");
            Console.WriteLine("= 5) Excluir Atividade  =");
            Console.WriteLine("=========================");

            //Metodo responsavel para transformar string em inteiro.
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                CriarAtividade();

                break;

                default:
                break;
                }
            }

        public void CriarAtividade() {

            Atividade atividade = new Atividade();

            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);

            }



        }
    }
