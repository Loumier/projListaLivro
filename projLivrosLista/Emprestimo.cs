using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Emprestimo
    {
        private DateTime dtEmprestimo, dtDevolucao;

        public DateTime getDtEmprestimo()
        {
            return this.dtEmprestimo;
        }
        
        public DateTime getDtDevolucao()
        {
            return this.dtDevolucao;
        }

        public Emprestimo()
        {
            this.dtEmprestimo = DateTime.Today;
            this.dtDevolucao = DateTime.Today.AddDays(7);
        }
    }
}
