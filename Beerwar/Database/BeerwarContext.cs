using Beerwar.Model;
using Microsoft.EntityFrameworkCore;

namespace Beerwar.Database;

public class BeerwarContext(DbContextOptions<BeerwarContext> options) : DbContext(options)
{
    public DbSet<Beer> Beers { get; set; }
    public DbSet<Match> MatchMaking { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Beer>().HasData(
            new Beer { Id = 1, Name = "Pilsener Urquell", Rating = 1500, MatchParticipation = 0, ImageSource = "puq" },
            new Beer { Id = 2, Name = "Becks", Rating = 1500, MatchParticipation = 0, ImageSource = "becks" },
            new Beer { Id = 3, Name = "Schlappe Seppel", Rating = 1500, MatchParticipation = 0, ImageSource = "schls" },
            new Beer { Id = 4, Name = "Augustiner", Rating = 1500, MatchParticipation = 0, ImageSource = "august" },
            new Beer { Id = 5, Name = "Veltins", Rating = 1500, MatchParticipation = 0, ImageSource = "velt" },
            new Beer { Id = 6, Name = "Guiness", Rating = 1500, MatchParticipation = 0, ImageSource = "guiness" },
            new Beer { Id = 7, Name = "Tannenzäpfle", Rating = 1500, MatchParticipation = 0, ImageSource = "tannenz" },
            new Beer { Id = 8, Name = "Holsten", Rating = 1500, MatchParticipation = 0, ImageSource = "holst" },
            new Beer { Id = 9, Name = "Braustüble", Rating = 1500, MatchParticipation = 0, ImageSource = "brst" },
            new Beer { Id = 10, Name = "Gude", Rating = 1500, MatchParticipation = 0, ImageSource = "gude" },
            new Beer { Id = 11, Name = "Pfungstädter", Rating = 1500, MatchParticipation = 0, ImageSource = "fungst" },
            new Beer { Id = 12, Name = "Licher", Rating = 1500, MatchParticipation = 0, ImageSource = "licher" },
            new Beer { Id = 13, Name = "Bitburger", Rating = 1500, MatchParticipation = 0, ImageSource = "bit" },
            new Beer { Id = 14, Name = "Eulchen", Rating = 1500, MatchParticipation = 0, ImageSource = "eulchen" },
            new Beer { Id = 15, Name = "Tyskie", Rating = 1500, MatchParticipation = 0, ImageSource = "tysk" },
            new Beer { Id = 16, Name = "Efes", Rating = 1500, MatchParticipation = 0, ImageSource = "ef" },
            new Beer { Id = 17, Name = "Chiemseer", Rating = 1500, MatchParticipation = 0, ImageSource = "chiemseer" },
            new Beer { Id = 18, Name = "Löwenbräu", Rating = 1500, MatchParticipation = 0, ImageSource = "löw" },
            new Beer { Id = 19, Name = "Hasseröder", Rating = 1500, MatchParticipation = 0, ImageSource = "hass" },
            new Beer { Id = 20, Name = "Erdinger", Rating = 1500, MatchParticipation = 0, ImageSource = "erd" },
            new Beer { Id = 21, Name = "Franziskaner", Rating = 1500, MatchParticipation = 0, ImageSource = "franz" },
            new Beer { Id = 22, Name = "Schönberger", Rating = 1500, MatchParticipation = 0, ImageSource = "schö" },
            new Beer { Id = 23, Name = "Mönchshof Original", Rating = 1500, MatchParticipation = 0, ImageSource = "möo" },
            new Beer { Id = 24, Name = "Warsteiner", Rating = 1500, MatchParticipation = 0, ImageSource = "warst" },
            new Beer { Id = 25, Name = "Binding", Rating = 1500, MatchParticipation = 0, ImageSource = "bin" },
            new Beer { Id = 26, Name = "Budweiser", Rating = 1500, MatchParticipation = 0, ImageSource = "bud" },
            new Beer { Id = 27, Name = "Schmucker", Rating = 1500, MatchParticipation = 0, ImageSource = "schmuck" },
            new Beer { Id = 28, Name = "Öttinger", Rating = 1500, MatchParticipation = 0, ImageSource = "ott" }
        );

        modelBuilder.Entity<Match>()
            .HasOne(m => m.BeerOne)
            .WithMany()
            .HasForeignKey(m => m.DuelantOneId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Match>()
            .HasOne(m => m.BeerTwo)
            .WithMany()
            .HasForeignKey(m => m.DuelantTwoId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}