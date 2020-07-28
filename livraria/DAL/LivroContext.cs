using livraria.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace livraria.DAL
{
    public class LivroContext : DbContext
    {
        public LivroContext() : base("LivroContext")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<LivroContext>());
        }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}