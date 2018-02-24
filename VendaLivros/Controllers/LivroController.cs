using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using VendaLivrosModel;
using VendaLivrosModel.LivrosModel;
using VendaLivrosProvider.Interface;

namespace VendaLivros.Controllers
{
    public class LivroController : ApiController
    {
        private readonly ILivroProvider _livrosProvider;
        private readonly MeuContext contexto;

        public LivroController(ILivroProvider livrosProvider)
        {
            _livrosProvider = livrosProvider;
            contexto = new MeuContext();
        }

        // GET: api/Livros
        [HttpGet]
        [Route("api/Livro/BuscarLivros")]
        public IEnumerable<Livro> BuscarLivros()
        {
            return _livrosProvider.GetLivros();
        }

        // GET: api/Livros/5
        public Livro Get(int id)
        {
            return _livrosProvider.GetLivro(id);
        }

        // PUT: api/Livros/5
        public HttpResponseMessage Put(int id, [FromBody]Livro livro)
        {
            _livrosProvider.SalvarLivro(id, livro);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        // POST: api/Livros
        public HttpResponseMessage Post(Object livro)
        {
            String livroJsonString = livro.ToString();
            Livro livroInclusao = JsonConvert.DeserializeObject<Livro>(livroJsonString);

            _livrosProvider.IncluirLivro(livroInclusao);

            return Request.CreateResponse(HttpStatusCode.Created);
        }

        // DELETE: api/Livros/5
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            _livrosProvider.ExcluirLivro(id);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}