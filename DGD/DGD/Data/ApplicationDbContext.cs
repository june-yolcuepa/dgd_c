using DGD.Models;
using Microsoft.EntityFrameworkCore;

namespace DGD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        
        }

        public DbSet<Boardgame> Boardgame { get; set; }

    }
}
