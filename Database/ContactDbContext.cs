using Microsoft.EntityFrameworkCore;
using Models;

namespace Database
{
    public class ContactDbContext : DbContext
    {
        public DbSet<ContactModel> Contacts { get; set; }
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactModel>().ToTable("Contacts");
        }
    }
}
