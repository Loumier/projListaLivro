using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos = new List<Emprestimo>;

        public bool emprestar()
        {
            if (disponivel)
            {
                emprestimos.Add(new Emprestimo());
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool devolver()
        {

        }

        public bool disponivel()
        {
            DateTime dataqw ;
            if (emprestimos.Count.Equals(0) || )
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public int qtdeEmprestimos()
        {
            return emprestimos.Count();
        }
    }
}
