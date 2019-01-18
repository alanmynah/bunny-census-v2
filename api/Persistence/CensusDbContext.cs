using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Persistence
{
    public class CensusDbContext : DbContext
    {
        public CensusDbContext(DbContextOptions<CensusDbContext> options) : base(options)
        {
            
        }

        public DbSet<CensusEntry> CensusEntries { get; set; }
        public DbSet<Bunny> Bunny { get; set; }
    }
}