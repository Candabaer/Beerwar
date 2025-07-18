namespace Beerwar.Model;

public class MatchMakingModel
{
    public int Id { get; init; }
    public DateTime Date { get; init; }
    
    public int? WinnerId { get; set; } 
    public int? RatingChange { get; set; } 
    
    public int DuelantOneId { get; init; }
    public BeerModel BeerOne { get; init; } = null!;
    public int DuelantTwoId { get; init; }
    public BeerModel BeerTwo { get; init; } = null!;
}