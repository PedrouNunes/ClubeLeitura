using System.Collections.Generic;
using System.Linq;

namespace ClubeLeitura.ConsoleApp.Compartilhado
{
    public class RepositorioBase<T> where T : EntidadeBase
    {
        protected readonly List<T> registros = new List<T>();
        protected int contadorNumero;

        public RepositorioBase()
        {
            registros = new List<T>();
        }

        public virtual void Inserir(T entidade)
        {
            registros.Add(entidade);
        }

        public void Editar(int numeroSelecionado, EntidadeBase entidade)
        {
            //editar
        }

        public bool Excluir(T entidade)
        {
            return registros.Remove(entidade);
        }

        public EntidadeBase SelecionarRegistro(int numeroRegistro)
        {
            return registros.Find(x => x.numero == numeroRegistro);
        }

        public EntidadeBase[] SelecionarTodos()
        {
            return registros.ToArray();
        }

        public bool ExisteRegistro(int numeroRegistro)
        {
            foreach (EntidadeBase registro in registros)
                if (registro.numero == numeroRegistro)
                    return true;

            return false;
        }
    }
}


