using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaLivrosModel.LivrosModel;

namespace VendaLivrosModel
{
    public class MeuContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        public MeuContext() : base("name = MeuContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
