using Aula1705.Controllers;
using Aula1705.Models;
using System;
using System.Collections.Generic;

namespace Aula1705.Views {
    class AtividadesView {

        enum MinhasOpcoes {
            CriarAtividades = 1,
            ListarAtividades = 2,
            BuscarAtividade = 3,
            EditarAtividade = 4,
            ExcluirAtividade = 5,
            BuscarNome = 6,
            ListAtivos = 7,
            Sair = 9

            }

        public void ExibirMenu() {
            MinhasOpcoes opcao = MinhasOpcoes.Sair;

            do {
                Console.Clear();
                Console.WriteLine("=========================");
                Console.WriteLine("= Escolha uma opção     =");
                Console.WriteLine("= 1) Criar Atividades   =");
                Console.WriteLine("= 2) Listar Atividades  =");
                Console.WriteLine("= 3) Buscar Atividade   =");
                Console.WriteLine("= 4) Editar Atividade   =");
                Console.WriteLine("= 5) Excluir Atividade  =");
                Console.WriteLine("= 6) Buscar por Nome    =");
                Console.WriteLine("= 7) Listar Atividades (Ativos/Inativos)=");

                Console.WriteLine("= 9) Sair  =");
                Console.WriteLine("=========================");


                //Metodo responsavel para transformar string em inteiro.

                opcao = (MinhasOpcoes)int.Parse(Console.ReadLine());

                switch (opcao) {
                    case MinhasOpcoes.CriarAtividades:
                    CriarAtividade();
                    break;
                    case MinhasOpcoes.ListarAtividades:
                    ListarAtividades();
                    break;
                    case MinhasOpcoes.BuscarAtividade:
                    BuscarAtividade();
                    break;
                    case MinhasOpcoes.EditarAtividade:
                    EditarAtividade();
                    break;
                    case MinhasOpcoes.ExcluirAtividade:
                    ExcluirAtividade();
                    break;
                    case MinhasOpcoes.BuscarNome:
                    BuscarPorNome();
                    break;
                    case MinhasOpcoes.ListAtivos:
                    ListarAtivos();
                    break;
                    case MinhasOpcoes.Sair:
                    break;
                    default:
                    Console.WriteLine("Opcao invalida!!! Digite qualquer tecla para continuar");
                    Console.ReadKey();
                    break;
                    }
                } while (opcao != MinhasOpcoes.Sair);
            }

        //Listar atividades ativas e inativas
        private void ListarAtivos() {
            AtividadesController atividadeController = new AtividadesController();
            

            Console.WriteLine("Listando atividades cadastradas");
            foreach (Atividade y in atividadeController.ListarPorStatus(true)) {
                ExibirDetalhesAtividade(y);
                }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();
            
        }

        //Buscar por atividades por nome
        private void BuscarPorNome() {
            AtividadesController atividadeController = new AtividadesController();

            Console.Write("Digite o nome da atividade: ");
            string Nome = Console.ReadLine();

            List<Atividade> lista = atividadeController.BuscarPorNome(Nome);
            if (lista.Count > 0) {
                foreach (Atividade a in lista) 
                    {
                    ExibirDetalhesAtividade(a);
                    }
                } else {
                Console.WriteLine("Atividade não encontrada");
                }

            Console.ReadKey();

            }

        //Excluir atividade
        private void ExcluirAtividade() {
            ListarAtividades();

            Console.Write("Digite o id da atividade que deseja excluir: ");
            int id = int.Parse(Console.ReadLine());

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Excluir(id);
            }
        
        //Editar ativades
        private void EditarAtividade() {
            ListarAtividades();

            Console.Write("Digite o id da atividade que deseja editar: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividadeAtualizada = ObterDadosAtividade();

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Editar(id, atividadeAtualizada);
            }

        //Criar Atividade
        public void CriarAtividade() {
            Atividade atividade = ObterDadosAtividade();

            AtividadesController atividadeController = new AtividadesController();
            atividadeController.Salvar(atividade);
            }

        //Obter dados
        private static Atividade ObterDadosAtividade() {
            Atividade atividade = new Atividade();

            Console.Write("Digite o nome da atividade: ");
            atividade.Nome = Console.ReadLine();

            Console.WriteLine("Ativo? (s/n)");
            atividade.Ativo = Console.ReadLine().ToLower() == "s";

            return atividade;
            }

        //Listar Atividades
        private void ListarAtividades() {
            AtividadesController atividadeController = new AtividadesController();

            Console.WriteLine("Listando atividades cadastradas");
            foreach (Atividade atividade in atividadeController.Listar()) {
                ExibirDetalhesAtividade(atividade);
                }
            Console.WriteLine("Fim da lista");
            Console.ReadKey();
            }

        //Buscar atividade
        private void BuscarAtividade() {
            AtividadesController atividadeController = new AtividadesController();

            Console.Write("Digite o id da atividade: ");
            int id = int.Parse(Console.ReadLine());

            Atividade atividade = atividadeController.BuscarPorID(id);

            if (atividade != null) {
                ExibirDetalhesAtividade(atividade);
                } else {
                Console.WriteLine("Atividade não encontrada");
                }

            Console.ReadKey();
            }

        //Exibir detalhes da atividade 
        private static void ExibirDetalhesAtividade(Atividade atividade) {
            Console.WriteLine("---");
            Console.WriteLine("Id: " + atividade.AtividadeID);
            Console.WriteLine("Nome: " + atividade.Nome);
            Console.WriteLine("Ativo: " + atividade.Ativo);
            Console.WriteLine("---");
            }
        }
    }
