using Microsoft.EntityFrameworkCore;
using MvcApp.ViewModel;

namespace MvcApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Person> People { get; set; }
    }

    public class Person
    {
        public long Id { get; set; }
        public Salutation Salutation { get; set; }
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}