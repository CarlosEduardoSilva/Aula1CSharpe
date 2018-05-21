using Aula1705.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705.Controllers {

    class AtividadesController {
        // simulando tabela
        private static List<Atividade> ListaAtividades { get; set; } //= new List<Atividade>();

        static AtividadesController() {
            ListaAtividades = new List<Atividade>();
            }
        //Salvar
        public void Salvar(Atividade atividade) {
            atividade.AtividadeID = ListaAtividades.Count + 1;
            ListaAtividades.Add(atividade);
            }

        //Listar
        public List<Atividade> Listar() {
            return ListaAtividades;
            }

        // Listar Ativos e inativos
        public List<Atividade> ListarPorStatus(bool status) {

            IEnumerable<Atividade> atividadesAtivas = new List<Atividade>();

            atividadesAtivas = from y in ListaAtividades
                               where y.Ativo = status
                               select y;

            return atividadesAtivas.ToList();
            
            }

        //BuscarPorID
        public Atividade BuscarPorID(int id) {
            foreach (Atividade a in ListaAtividades) {
                if (a.AtividadeID == id) {
                    return a;
                    }
                }

            return null;
            }

        //Buscar por Nome
        public List<Atividade> BuscarPorNome(string Nome) {


            IEnumerable<Atividade> atividadesSelecionadas = new List<Atividade>();

            atividadesSelecionadas = from x in ListaAtividades
                                     where x.Nome.ToLower().Contains(Nome.ToLower())
                                     select x;

            return atividadesSelecionadas.ToList();

            }

        //Editar
        public void Editar(int id, Atividade atividadeAtualizada) {
            Atividade atividadeAntiga = BuscarPorID(id);

            if (atividadeAntiga != null) {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;
                }
            }

        //Excluir
        public void Excluir(int id) {
            Atividade atividade = BuscarPorID(id);

            if (atividade != null) {
                ListaAtividades.Remove(atividade);
                }
            }
        }
    }
