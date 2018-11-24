using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Models
{


    public class DocumentsDbContext : DbContext
    {

        public DbSet<Documents> Documents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=Documents.db");
        }

        protected override void OnModelCreating(ModelBuilder optionsBuilder)
        {
            optionsBuilder.Entity<Documents>().HasData(
                new Documents { Id = 1, Title = "Lorem Ipsum", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ut leo eu tortor pretium malesuada." },
                new Documents { Id = 2, Title = "Dolor Sit", Description = "Vestibulum nec magna eu tortor ullamcorper iaculis. Vivamus faucibus volutpat varius. " },
                new Documents { Id = 3, Title = "Consectetur", Description = "Ut ultricies sollicitudin nibh, sit amet ultricies orci faucibus eu. Duis eu nisl dolor. Vestibulum quam velit, aliquam id dictum a, rutrum eu sem. " });
    }
    }


}
