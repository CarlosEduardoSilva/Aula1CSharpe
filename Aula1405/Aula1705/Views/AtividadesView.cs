using Aula1705.Controllers;
using Aula1705.Models;
using System;

namespace Aula1705.Views {
    class AtividadesView {


        private AtividadesController atividadeController;

        enum MinhasOpcoes 
            {
                CriarAtividades = 1,
                ListarAtividades = 2,
                BuscarAtividade  =3,
                EditarAtividade = 4,
                ExcluirAtivdade = 5,

            } 

        public AtividadesView() {
            new AtividadesController();
            }
        int opcao = 0;
                
        public void ExibirMenu() {
            
            do {
                Console.Clear();
                Console.WriteLine("=========================");
                Console.WriteLine("= Escolha uma opção     =");
                Console.WriteLine("= 1) Criar Atividades   =");
                Console.WriteLine("= 2) Listar Atividades  =");
                Console.WriteLine("= 3) Buscar Atividade   =");
                Console.WriteLine("= 4) Editar Atividade   =");
                Console.WriteLine("= 5) Excluir Atividade  =");
                Console.WriteLine("= 9) Sair  =");
                Console.WriteLine("=========================");


                //Metodo responsavel para transformar string em inteiro.
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao) {
                    case 1:
                    CriarAtividade();

                    break;

                    case 2:
                    ListarAtividades();

                    break;

                    case 3:
                    BuscarAtividade();

                    break;

                    case 4:
                    EditarAtividade();

                    break;

                    case 5:
                    ExcluirAtividade();

                    break;

                    default:
                    break;
                    }
                } while (opcao != 9 );
            }

        private void ExcluirAtividade() {
            ListarAtividades();
            ListarAtividades();
            Console.WriteLine("Digite o id da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            atividadeController.Excluir(id);

            }

        private void EditarAtividade() {
            ListarAtividades();
            Console.WriteLine("Digite o id da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            atividadeController.Editar(id, atividadeAtualizada);
            
            }

        public void CriarAtividade() {
            Atividade atividade = ObterDadosAtividade();

            AtividadesController atividadeCtrl = new AtividadesController();
            atividadeCtrl.Salvar(atividade);

            }

        private static Atividade ObterDadosAtividade() {
            Atividade atividade = new Atividade();

            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            atividade.Ativo = true;
            return atividade;
            }

        private void BuscarAtividade() {

            AtividadesController atividadeController = new AtividadesController();
            Console.Write("Digite o id da atividade: ");

            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.BuscarPorId(id);

            if(atividade != null) {

                ExibirdetalhesAtividade(atividade);

                } else {
                Console.WriteLine("Atividade não encontrada");
                }
            }

        private void ListarAtividades() {
            AtividadesController atividadeController = new AtividadesController();

            Console.WriteLine("Listando atividades cadastradas");


            foreach (Atividade atividade in atividadeController.Listar()) {
                ExibirdetalhesAtividade(atividade);

                }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();


            }    

        
        private static void ExibirdetalhesAtividade(Atividade atividade) {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeId);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
            }
        }
    }
