using Beerwar.Model;
using Microsoft.EntityFrameworkCore;

namespace Beerwar.Database;

public class BeerwarContext(DbContextOptions<BeerwarContext> options) : DbContext(options)
{
    public DbSet<BeerModel> Beers { get; set; }
    public DbSet<MatchMakingModel> MatchMaking { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BeerModel>().HasData(
            new BeerModel { Id = 1, Name = "Pilsener Urquell", Rating = 1500, MatchParticipation = 0, ImageSource = "puq" },
            new BeerModel { Id = 2, Name = "Becks", Rating = 1500, MatchParticipation = 0, ImageSource = "becks" },
            new BeerModel { Id = 3, Name = "Schlappe Seppel", Rating = 1500, MatchParticipation = 0, ImageSource = "schls" },
            new BeerModel { Id = 4, Name = "Augustiner", Rating = 1500, MatchParticipation = 0, ImageSource = "august" },
            new BeerModel { Id = 5, Name = "Veltins", Rating = 1500, MatchParticipation = 0, ImageSource = "velt" },
            new BeerModel { Id = 6, Name = "Guiness", Rating = 1500, MatchParticipation = 0, ImageSource = "guiness" },
            new BeerModel { Id = 7, Name = "Tannenzäpfle", Rating = 1500, MatchParticipation = 0, ImageSource = "tannenz" },
            new BeerModel { Id = 8, Name = "Holsten", Rating = 1500, MatchParticipation = 0, ImageSource = "holst" },
            new BeerModel { Id = 9, Name = "Braustüble", Rating = 1500, MatchParticipation = 0, ImageSource = "brst" },
            new BeerModel { Id = 10, Name = "Gude", Rating = 1500, MatchParticipation = 0, ImageSource = "gude" },
            new BeerModel { Id = 11, Name = "Pfungstädter", Rating = 1500, MatchParticipation = 0, ImageSource = "fungst" },
            new BeerModel { Id = 12, Name = "Licher", Rating = 1500, MatchParticipation = 0, ImageSource = "licher" },
            new BeerModel { Id = 13, Name = "Bitburger", Rating = 1500, MatchParticipation = 0, ImageSource = "bit" },
            new BeerModel { Id = 14, Name = "Eulchen", Rating = 1500, MatchParticipation = 0, ImageSource = "eulchen" },
            new BeerModel { Id = 15, Name = "Tyskie", Rating = 1500, MatchParticipation = 0, ImageSource = "tysk" },
            new BeerModel { Id = 16, Name = "Efes", Rating = 1500, MatchParticipation = 0, ImageSource = "ef" },
            new BeerModel { Id = 17, Name = "Chiemseer", Rating = 1500, MatchParticipation = 0, ImageSource = "chiemseer" },
            new BeerModel { Id = 18, Name = "Löwenbräu", Rating = 1500, MatchParticipation = 0, ImageSource = "löw" },
            new BeerModel { Id = 19, Name = "Hasseröder", Rating = 1500, MatchParticipation = 0, ImageSource = "hass" },
            new BeerModel { Id = 20, Name = "Erdinger", Rating = 1500, MatchParticipation = 0, ImageSource = "erd" },
            new BeerModel { Id = 21, Name = "Franziskaner", Rating = 1500, MatchParticipation = 0, ImageSource = "franz" },
            new BeerModel { Id = 22, Name = "Schönberger", Rating = 1500, MatchParticipation = 0, ImageSource = "schö" },
            new BeerModel { Id = 23, Name = "Mönchshof Original", Rating = 1500, MatchParticipation = 0, ImageSource = "möo" },
            new BeerModel { Id = 24, Name = "Warsteiner", Rating = 1500, MatchParticipation = 0, ImageSource = "warst" },
            new BeerModel { Id = 25, Name = "Binding", Rating = 1500, MatchParticipation = 0, ImageSource = "bin" },
            new BeerModel { Id = 26, Name = "Budweiser", Rating = 1500, MatchParticipation = 0, ImageSource = "bud" },
            new BeerModel { Id = 27, Name = "Schmucker", Rating = 1500, MatchParticipation = 0, ImageSource = "schmuck" },
            new BeerModel { Id = 28, Name = "Öttinger", Rating = 1500, MatchParticipation = 0, ImageSource = "ott" }
        );

        modelBuilder.Entity<MatchMakingModel>()
            .HasOne(m => m.BeerOne)
            .WithMany()
            .HasForeignKey(m => m.DuelantOneId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<MatchMakingModel>()
            .HasOne(m => m.BeerTwo)
            .WithMany()
            .HasForeignKey(m => m.DuelantTwoId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}