using Microsoft.EntityFrameworkCore;

namespace PlanoFitApi.Models;

public class PlanoFitContext : DbContext
{
    public PlanoFitContext(DbContextOptions<PlanoFitContext> options)
        : base(options) { }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<PerfilFitness> PerfilFitness { get; set; }
    public DbSet<Plano> Plano { get; set; }
}
