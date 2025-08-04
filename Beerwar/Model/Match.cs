using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Model;

public class Match
{
    public Match() { }
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

    public double ExpectedWinProbability { get; set; }
    public double ExpectedLoseProbability { get; set; }
    public int DuelantOneId { get; init; }
    public Beer BeerOne { get; init; }
    
    public int DuelantTwoId { get; init; }
    public Beer BeerTwo { get; init; } 

    public Beer GetWinner(bool getWinner)
    {
        if (WinnerId == null)
            throw new InvalidOperationException("Winner id is null, meaning its not defined at the moment");
        if (getWinner)
            return WinnerId == DuelantOneId ? BeerOne : BeerTwo;
        return WinnerId == DuelantOneId ? BeerTwo : BeerOne;
    }
}