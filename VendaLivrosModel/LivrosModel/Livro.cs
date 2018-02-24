using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaLivrosModel.LivrosModel
{
    public class Livro
    {
        public int ID { get; set; }
        public string Titulo { get; set; }
        public string DataLancamento { get; set; }
        public double Preco { get; set; }
    }
}
