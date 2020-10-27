using Microsoft.EntityFrameworkCore;
using mintapi.Model;
namespace mintapi.Data{
    public class DataContext:DbContext{
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet <Student> Student { get; set; }
         public DbSet <Department> Department { get; set; }
          public DbSet <Faculty> Faculty { get; set; }
           public DbSet <Cuorse> Cuorse { get; set; }
            public DbSet <Grade> Grade { get; set; }
    }
}