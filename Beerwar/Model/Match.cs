using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Model;

public class Match
{
    public Match(Beer beerOne, Beer beerTwo)
    {
        DuelantOneId = beerOne.Id;
        DuelantTwoId = beerTwo.Id;
        BeerOne = beerOne;
        BeerTwo = beerTwo;
        Date = DateTime.Now;
    }

    public int Id { get; init; }
    public DateTime Date { get; init; }

    public int? WinnerId { get; set; } = null;
    public int? RatingChange { get; set; }

    public int DuelantOneId { get; init; }
    public Beer BeerOne { get; init; } = null!;
    public int DuelantTwoId { get; init; }
    public Beer BeerTwo { get; init; } = null!;
    public double ExpectedWinrateBeerOne;

    public Beer GetWinner()
    {
        if (WinnerId == null)
            throw new InvalidOperationException("Winner id is null, meaning its not defined at the moment");
        return WinnerId == DuelantOneId ? BeerOne : BeerTwo;
    }

    public Beer GetLoser()
    {
        if (WinnerId == null)
            throw new InvalidOperationException("Winner id is null, meaning its not defined at the moment");
        return WinnerId == DuelantOneId ? BeerTwo : BeerOne;
    }
}