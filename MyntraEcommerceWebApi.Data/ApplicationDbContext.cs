using Microsoft.EntityFrameworkCore;
using MyntraEcommerceWebApi.Model;

namespace MyntraEcommerceWebApi.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Address> Address { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Category> Category { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>().HasOne(a=>a.Address).WithOne(b=>b.Customer).HasForeignKey<Address>(b=>b.AddressId);
    }
}
