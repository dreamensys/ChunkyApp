
using Microsoft.EntityFrameworkCore; 
namespace Chunky.Data.Access.DAL
{
    public class MainDBContext : DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}