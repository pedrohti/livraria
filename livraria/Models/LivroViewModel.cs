using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace livraria.Models
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        public long ISBN { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public double Preco { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Capa { get; set; }
    }
}