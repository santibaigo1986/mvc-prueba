using Microsoft.EntityFrameworkCore;

namespace EfDemo.Models
{
    public class DemoContex : DbContext 
    {
        public DbSet<UserModel> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data Source=C:\Temp\Demo.db"); 
    }
}
