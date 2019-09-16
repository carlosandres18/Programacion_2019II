using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace student_app.models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }
        
        public DbSet<student> students { get; set; }

    }
}