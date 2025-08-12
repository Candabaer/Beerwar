namespace Beerwar.DTO
{
	public record MatchData
	{
		int BeerOneId { get; set; }
		int BeerTwoId { get; set; }
		int MatchId	{ get; set; }
	}
}
