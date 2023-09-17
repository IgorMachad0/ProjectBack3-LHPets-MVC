using Microsoft.EntityFrameworkCore;

namespace LHPets.Models
{

public class Context : DbContext{

    public Context(DbContextOptions<Context> options) : base(options){

    }

    public DbSet<Customers> Customer { get; set; }
}
}