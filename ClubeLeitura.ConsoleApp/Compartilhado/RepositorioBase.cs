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

        public virtual string Inserir(T entidade)
        {
            registros.Add(entidade);
            return "Inserido com Sucesso!";
        }

        public void Editar(int numeroSelecionado, EntidadeBase entidade)
        {
            //editar
        }

        public void Excluir(int numeroSelecionado)
        {
            registros.RemoveAt(numeroSelecionado);
        }

        public EntidadeBase SelecionarRegistro(int numeroRegistro)
        {
            return registros.Find(x => x.numero == numeroRegistro);
        }

        public List<T> SelecionarTodos()
        {
            return registros;
        }

        public bool ExisteRegistro(int numeroRegistro)
        {
            return registros.Exists(x => x.numero == numeroRegistro);
        }
    }
}


