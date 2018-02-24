using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaLivrosModel;
using VendaLivrosModel.LivrosModel;
using VendaLivrosRepository.Interface;

namespace VendaLivrosRepository.Repository
{
    public class LivroRepository : ILivroRepository, IDisposable
    {
        private readonly MeuContext context;

        public LivroRepository(MeuContext context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void ExcluirLivro(int id)
        {
            Livro livroSerExcluido = context.Livros.FirstOrDefault(x => x.ID == id);
            context.Livros.Remove(livroSerExcluido);
        }

        public Livro GetLivro(int id)
        {
            return context.Livros.FirstOrDefault(x => x.ID == id);
        }

        public IEnumerable<Livro> GetLivros()
        {
            return context.Livros.OrderBy(x => x.Titulo).ToList();
        }

        public void IncluirLivro(Livro livro)
        {
            context.Livros.Add(livro);
        }

        public void SalvarLivro(int id, Livro livroNovo)
        {
            Livro livroAntigo = context.Livros.FirstOrDefault(x => x.ID == id);
            context.Livros.Remove(livroAntigo);
            context.Livros.Add(livroNovo);
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
