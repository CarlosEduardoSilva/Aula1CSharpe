using Modelos;
using System.Collections.Generic;

namespace Controllers
{
    class UsuariosController
    {

        private static List<Usuario> ListaUsuarios { get; set; }
        private static int incrementoID = 0;

        //Criação da lista 
        static UsuariosController()
        {
            ListaUsuarios = new List<Usuario>();
        }

        //Salvar
        public void Salvar(Usuario usuario)
        {
            usuario.UsuarioID = incrementoID++;
            ListaUsuarios.Add(usuario);
        }

        //Listar usuarios cadastrados;
        public List<Usuario> Listar()
        {
            return ListaUsuarios;
        }

        //Buscar por ID
        public Usuario BuscarPorID(int id)
        {
            foreach (Usuario u in ListaUsuarios)
            {
                if (u.UsuarioID == id)
                {
                    return u;
                }

            }
            return null;
        }

        //Editar usuarios
        public void Editar(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioAntigo = BuscarPorID(id);

            if(usuarioAntigo != null)
            {
                usuarioAntigo.Nome = usuarioAtualizado.Nome;
                usuarioAntigo.Ativo = usuarioAtualizado.Ativo;                
            }
        }

        public void Excluir(int id)
        {
            Usuario usuario = BuscarPorID(id);

            ListaUsuarios.Remove(usuario);

        }   
    }
}
