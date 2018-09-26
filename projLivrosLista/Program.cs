using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projLivrosLista
{
    class Program
    {
        static void Main(string[] args)
        {
            bool executar = true;
            int opcao;
            Livros livros = new Livros();

            do
            {

                opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        executar = false;
                        break;
                    case 1:
                        Console.WriteLine("");
                        Livros.adicionar;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
            while (executar);
        }
    }
}
