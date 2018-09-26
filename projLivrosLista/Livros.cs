using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Livros
    {
        private List<Livro> acervo = new List<Livro>();

        public void adicionar (Livro livro)
        {
            Console.WriteLine("Código ISBN: ");
            int lIsbn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Título do livro: ");
            string lTitulo = Console.ReadLine();
            Console.WriteLine("Autor de livro: ");
            string lAutor = Console.ReadLine();
            Console.WriteLine("Editora do livro: ");
            string lEditora = Console.ReadLine();
            Livro livro = new Livro(lIsbn, lTitulo, lAutor, lEditora);
            acervo.Add(livro);
        }

        public Livro pesquisar (Livro livro)
        {
            return new Livro();
        }
    }
}
