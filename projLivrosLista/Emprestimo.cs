using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Emprestimo
    {
        private const double LimiteEmprestimo = 7;
        private DateTime dtEmprestimo, dtDevolucao;

        public DateTime getDtEmprestimo()
        {
            return this.dtEmprestimo;
        }

        public void setDtEmprestimo()
        {
            this.dtEmprestimo = DateTime.Today;
        }

        public DateTime getDtDevolucao()
        {
            return this.dtDevolucao;
        }

        public void setDtDevolucao()
        {
            this.dtDevolucao = this.dtEmprestimo.AddDays(LimiteEmprestimo);
        }
    }
}
