using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace multinacional_company.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<reporte> reportes2 { get; set; }

    }
}