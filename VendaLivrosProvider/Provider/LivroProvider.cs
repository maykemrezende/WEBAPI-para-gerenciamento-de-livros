using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaLivrosModel.LivrosModel;
using VendaLivrosProvider.Interface;
using VendaLivrosRepository.Interface;

namespace VendaLivrosProvider.Provider
{
    public class LivroProvider : ILivroProvider
    {
        private readonly ILivroRepository livroRepository;

        public LivroProvider(ILivroRepository livroRepository)
        {
            this.livroRepository = livroRepository;
        }

        public void ExcluirLivro(int id)
        {
            livroRepository.ExcluirLivro(id);
            livroRepository.Save();
        }

        public Livro GetLivro(int id)
        {
            return livroRepository.GetLivro(id);
        }

        public IEnumerable<Livro> GetLivros()
        {
            return livroRepository.GetLivros();
        }

        public void IncluirLivro(Livro livro)
        {
            livroRepository.IncluirLivro(livro);
            livroRepository.Save();
        }

        public void SalvarLivro(int id, Livro livro)
        {
            livroRepository.SalvarLivro(id, livro);
            livroRepository.Save();
        }
    }
}
