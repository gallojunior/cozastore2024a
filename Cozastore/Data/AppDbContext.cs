using Cozastore.Models;
using CozaStore.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cozastore.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Cor> Cores { get; set; }
    public DbSet<Estoque> Estoques { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<ProdutoFoto> ProdutoFotos { get; set; }
    public DbSet<Tamanho> Tamanhos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);

        #region Relacionamento de Muitos para Muitos - Estoque
        builder.Entity<Estoque>()
            .HasOne(e => e.Produto)
            .WithMany(p => p.Estoque)
            .HasForeignKey(e => e.ProdutoId);
        
        builder.Entity<Estoque>()
            .HasOne(e => e.Tamanho)
            .WithMany(t => t.Estoque)
            .HasForeignKey(e => e.TamanhoId);
        
        builder.Entity<Estoque>()
            .HasOne(e => e.Cor)
            .WithMany(c => c.Estoque)
            .HasForeignKey(e => e.CorId);
        #endregion
        
    }

}