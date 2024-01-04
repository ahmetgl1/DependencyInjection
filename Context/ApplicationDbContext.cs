using DependencyInjection.Model;
using Microsoft.EntityFrameworkCore;

namespace DependencyInjection.Context;

public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(DbContextOptions options) : base(options) { }

    DbSet<Product> Products { get; set; }
    

}
