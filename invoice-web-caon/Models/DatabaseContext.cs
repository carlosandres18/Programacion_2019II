using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace invoice_web_caon.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<reporte> reportes { get; set; }

    }
}