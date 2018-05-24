using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.Base {
    interface IBaseController<T> where T: class {
       
        IList<T> ListarTodos();
        IList<T> ListarPorNome();
        T BuscarPorID(int id);
        void Atualizar(T entity);
        void Excluir(int id);         
        }
    }
