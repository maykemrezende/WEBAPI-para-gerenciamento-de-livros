using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendaLivros.Models;

namespace VendaLivrosTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Livro livro = new Livro();
            livro.Id = 1;
            livro.Titulo = "teste";
            livro.DataLancamento = "01/01/2015";
            livro.Preco = 2.10;
        }
    }
}
