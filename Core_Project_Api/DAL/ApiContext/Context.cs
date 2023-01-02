using Core_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Project_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-ODEOOI6\\SQLEXPRESS;database=CoreProjectDB2;integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
