using Modelos;
using System.Collections.Generic;

namespace Controllers {
    class AtividadesController {

        private static List<Atividade> ListaAtividades { get; set; }
        private static int UltimoIdUtilizado = 1;

        //Aqui criamos nossa lista efetivamente

        static AtividadesController() {
            ListaAtividades = new List<Atividade>();
            }

        //Salvar nova atividade || Atividade(Parametro que vem da Model), atividade(nome que criamos).
        public void Salvar(Atividade atividade) {
            atividade.AtividadeID = UltimoIdUtilizado++;
            ListaAtividades.Add(atividade);
            }
        //Listar atividades criadas
        public List<Atividade> Listar() {
            return ListaAtividades;
            }

        //Buscar por ID
        public Atividade BuscarPorID(int id) {

            foreach (Atividade a in ListaAtividades) {
                if (a.AtividadeID == id) {
                    return a;
                    }
                }
            return null;
            }

        //Editar atividades
        public void Editar(int id, Atividade atividadeAtualizada) {
            Atividade atividadeAntiga = BuscarPorID(id);

            if (atividadeAntiga != null) {
                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Descricao = atividadeAtualizada.Descricao;
                atividadeAtualizada.Ativo = atividadeAtualizada.Ativo;
                atividadeAntiga.CategoriaID = atividadeAtualizada.CategoriaID;
                atividadeAntiga.UsuarioID = atividadeAtualizada.UsuarioID;
                }
            }

        //Excluir atividades
        public void Excluir(int id) {
            Atividade atividade = BuscarPorID(id);

            if (atividade != null) {
                ListaAtividades.Remove(atividade);
                }
            }
        }
    }
