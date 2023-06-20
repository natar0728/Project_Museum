using Microsoft.EntityFrameworkCore;
using Museum.Models;

namespace Museum.Data
{
    public class MuseumContext : DbContext
    {
        public MuseumContext(DbContextOptions<MuseumContext> options) : base(options)
        {

        }


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<>
        //}


        public DbSet<Autor>? Autores { get; set; } 
        public DbSet<Exposicion>? Exposiciones { get; set; }
        public DbSet<Obra>? Obras { get; set; }
        public DbSet<Ticket>? Tickets { get; set; }
        public DbSet<Client> ?Clientes { get; set; }

       


    }
}
