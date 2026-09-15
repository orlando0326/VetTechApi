using Microsoft.EntityFrameworkCore;
using VetTechApi.Models;

namespace VetTechApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Consulta> consultas{ get; set; }

        public DbSet<Pet> pets{ get; set; }

        public DbSet<Tutor> tutors{ get; set; }

        public DbSet<Veterinario> veterinarios { get; set; }
    }
}