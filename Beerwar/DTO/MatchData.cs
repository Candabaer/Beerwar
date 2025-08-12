using System.ComponentModel.DataAnnotations;
using Beerwar.Model;

namespace Beerwar.DTO
{
	public record MatchData
	{
		[Required]
		public int BeerOneId { get; set; }
		[Required]
		public int BeerTwoId { get; set; }
		[Required]
		public Guid MatchId	{ get; set; }

		public MatchData(Match match)
		{
			BeerOneId = match.DuelantOneId;
			BeerTwoId = match.DuelantTwoId;
			MatchId = match.Id;
		}
	}
}
