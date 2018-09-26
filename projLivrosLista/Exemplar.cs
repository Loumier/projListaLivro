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
        private List<Emprestimo> ListaDeEmprestimos = new List<Emprestimo>;

        public bool emprestar()
        {

        }

        public bool devolver()
        {

        }

        public bool disponivel()
        {

        }

        public int qtdeEmprestimos()
        {

        }

        //Getters & Setters
        public void setTombo(int gTombo)
        {
            this.tombo = gTombo;
        }

        public int getTombo()
        {
            return tombo;
        }
    }
}
