using Modelos;
using System.Collections.Generic;

namespace Controllers
{
    public class CategoriasController
    {

        private static List<Categoria> ListaCategoria { get; set; }
        private static int incrementoID = 0;
        //Criada a Lista 
        static CategoriasController()
        {
            ListaCategoria = new List<Categoria>();
        }


        //Salvar

        public void Salvar(Categoria categoria)
        {
            categoria.CategoriaID = incrementoID++;
            ListaCategoria.Add(categoria);
        }

        public List<Categoria> Listar()
        {
            return ListaCategoria;
        }

        //Buscar por ID
        public Categoria BuscarPorID(int id)
        {
            foreach (Categoria c in ListaCategoria)
            {
                if (c.CategoriaID == id)
                {
                    return c;
                }
            }
            return null;
        }

        //Editar categorias
        public void Editar(int id, Categoria categoriaAtualizada)
        {
            Categoria categoriaAntiga = BuscarPorID(id);

            if(categoriaAntiga != null)
            {
                categoriaAntiga.Nome = categoriaAtualizada.Nome;
                categoriaAntiga.Ativo = categoriaAtualizada.Ativo;
            }


        }
        //Excluir categorias
        public void Excluir(int id)
        {
            Categoria categoria = BuscarPorID(id);

            ListaCategoria.Remove(categoria);

        }


    }
}
