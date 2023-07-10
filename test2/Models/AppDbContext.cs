using Microsoft.EntityFrameworkCore;
using test2.Models.Article;
using test2.Models.Department;

namespace test2.Models
{
    public class AppDbContext :DbContext
    {
        public DbSet<ContactUsTbl> contactUs { get; set; }
        public DbSet<UserTbl> users { get; set; }
        public DbSet<ArticleTbl> articles { get; set; }
        public DbSet<Department.Department> Department { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=127.0.0.1;Port=3306;Database=test1;Uid=root;Pwd=12345678;");
        }
    }
}
