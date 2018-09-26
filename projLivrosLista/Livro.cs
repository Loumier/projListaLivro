using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livro
    {
        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares = new List<Exemplar>();

            public void adicionarExemplar(Exemplar exemplar)
        {

        }

        public int qtdeExemplares()
        {
            exemplares.
        }

        public int qtdeDisponiveis()
        {

        }

        public int qtdeEmprestimos()
        {

        }

        public double percDisponibilidade()
        {

        }

        public Livro(int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
        }

        public int getIsbn()
        {
            return this.isbn;
        }

        public void setIsbn(int gIsbn)
        {
            this.isbn = gIsbn;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public void setTitulo(string gTitulo)
        {
            this.titulo = gTitulo;
        }

        public string getAutor()
        {
            return this.autor;
        }

        public void setAutor(string gAutor)
        {
            this.autor = gAutor;
        }

        public string getEdidora()
        {
            return editora;
        }

        public void setEditora(string gEditora)
        {
            this.editora = gEditora;
        }

    }
}
