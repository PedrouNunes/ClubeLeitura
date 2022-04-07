using ClubeLeitura.ConsoleApp.Compartilhado;
using System.Collections.Generic;

namespace ClubeLeitura.ConsoleApp.ModuloEmprestimo
{
    public class RepositorioEmprestimo : RepositorioBase<Emprestimo>
    {

        public bool RegistrarDevolucao(Emprestimo emprestimo)
        {
            emprestimo.Fechar();

            return true;
        }

        public List<Emprestimo> SelecionarEmprestimosAbertos()
        {
            List<Emprestimo> emprestimosAbertos = new List<Emprestimo>();

            foreach (Emprestimo emprestimo in registros)
            {
                if (emprestimo.estaAberto)
                    emprestimosAbertos.Add(emprestimo);
            }

            return emprestimosAbertos;
        }
    }
}
