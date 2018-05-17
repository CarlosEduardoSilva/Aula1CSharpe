using Aula1705.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1705.Controllers {
    class AtividadesController {
        //Simulando tabela
        public List<Atividade> ListaAtividades { get; set; }


        public AtividadesController() {

            ListaAtividades = new List<Atividade>();
            }

        public int MyProperty { get; set; }
        
        //Salvar
        public void Salvar(Atividade atividade) {

            ListaAtividades.Add(atividade);
                            
            }
        
        //Listar
        public List<Atividade> Listar() {

            return ListaAtividades;

            }

        //BuscarPorId
        public Atividade BuscarPorId(int id) {

            foreach (Atividade a in ListaAtividades) {
                if(a.AtividadeId == id) {

                    return a;

                    }
                }

            return null;
            }
        
        //Editar
        public void Editar(int id, Atividade atividadeAtualizada) {

            Atividade atividadeAntiga = BuscarPorId(id);

                if(atividadeAntiga != null) {

                atividadeAntiga.Nome = atividadeAtualizada.Nome;
                atividadeAntiga.Ativo = atividadeAtualizada.Ativo;

                }
                
            }

        
        //Excluir
        public void Excluir(int id) {

            Atividade atividade = BuscarPorId(id);
            if (atividade != null) {

                ListaAtividades.Remove(atividade);
                    
                }
            }
        }
    }
