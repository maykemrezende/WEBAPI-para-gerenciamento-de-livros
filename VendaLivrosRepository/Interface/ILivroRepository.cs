using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaLivrosModel.LivrosModel;

namespace VendaLivrosRepository.Interface
{
    public interface ILivroRepository : IDisposable
    {
        Livro GetLivro(int id);

        IEnumerable<Livro> GetLivros();

        void IncluirLivro(Livro livro);

        void SalvarLivro(int id, Livro livro);

        void ExcluirLivro(int id);

        void Save();
    }
}
