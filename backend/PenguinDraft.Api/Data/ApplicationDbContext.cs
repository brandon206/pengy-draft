using Microsoft.EntityFrameworkCore;
using PenguinDraft.Api.Models;

namespace PenguinDraft.Api.Data
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }

    public DbSet<Card> Cards { get; set; }
    public DbSet<Deck> Decks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // Configure entity relationships and additional settings here
    }

  }
}