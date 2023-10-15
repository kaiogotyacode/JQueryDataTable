using JQueryDataTable.Models;
using Microsoft.EntityFrameworkCore;

namespace JQueryDataTable.Database
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        public DbSet<People> Peoples { get; set; }
    }
}
