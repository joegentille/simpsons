using Microsoft.EntityFrameworkCore;
using Simpsons.Core.Entities;

namespace Simpsons.Infrastructure.Data
{
    public class SimpsonsContext : DbContext
    {
        public SimpsonsContext(DbContextOptions<SimpsonsContext> options) : base(options)
        {

        }

        public DbSet<Character> Characters { get; set; }
        
    }
}