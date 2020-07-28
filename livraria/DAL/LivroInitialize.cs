using livraria.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace livraria.Models
{
	public class LivroInitialize : DropCreateDatabaseIfModelChanges<LivroContext>
	{
		protected override void Seed(LivroContext context)
		{
			var livros = new List<Livro>
			{
				new Livro
				{
					ISBN=9780195101706,
					Autor="Machado de Assis",
					Titulo="Memórias Póstumas de Brás Cuba",
					Preco=22.67,
					DataPublicacao=DateTime.Parse("2012-07-04"),
					Capa="https://m.media-amazon.com/images/I/51rG7b0DjJL.jpg",
				},
				new Livro
				{
					ISBN=8573026278,
					Autor="Stephen King",
					Titulo="Pesadelos e Paisagens Noturnas - Vol. 1",
					Preco=45.91,
					DataPublicacao=DateTime.Parse("2004-08-19"),
					Capa="https://i.imgur.com/40arP1w.jpeg",
				}
			};

			livros.ForEach(livro => context.Livros.Add(livro));
			context.SaveChanges();
		}
	}
}