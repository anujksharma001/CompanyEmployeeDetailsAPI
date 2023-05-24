using Demo_Company_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo_Company_API.Data
{
    public class AgentsAPIDbContext : DbContext
    {
        public AgentsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Agent> Agents { get; set; }
    }
}
