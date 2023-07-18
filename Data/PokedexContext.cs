using Microsoft.EntityFrameworkCore;
using PokedexAPI.Models;

namespace PokedexAPI.Data;

public partial class PokedexContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public PokedexContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public virtual DbSet<Pokemon> Pokemon { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = Configuration["Pokedex:ConnectionString"];
        var serverVersion = ServerVersion.AutoDetect(connectionString);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Pokemon>(entity =>
        {
            entity.HasKey(e => e.Ndex).HasName("PRIMARY");

            entity.ToTable("pokemon");

            entity.Property(e => e.Ndex).ValueGeneratedNever();
            entity.Property(e => e.ImageUrl)
                .HasMaxLength(255)
                .HasColumnName("ImageURL");
            entity.Property(e => e.Name).HasMaxLength(20);
            entity.Property(e => e.Type1).HasMaxLength(20);
            entity.Property(e => e.Type2).HasMaxLength(20);
        });

    }
}
