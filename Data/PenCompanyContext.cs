using Microsoft.EntityFrameworkCore;
using PenCompany.Models;

namespace PenCompany.Data
{
    public class PenCompanyContext : DbContext
    {
        public PenCompanyContext(DbContextOptions<PenCompanyContext> options)
            : base(options)
        {
        }

        public DbSet<Pen> Pen { get; set; }
    }
}