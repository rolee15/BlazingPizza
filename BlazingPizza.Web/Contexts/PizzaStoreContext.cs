using BlazingPizza.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazingPizza.Contexts;

public class PizzaStoreContext : DbContext
{
    public PizzaStoreContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<PizzaSpecial> Specials { get; set; }
}

