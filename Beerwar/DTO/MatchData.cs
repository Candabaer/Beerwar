using System.ComponentModel.DataAnnotations;
using Beerwar.Model;

namespace Beerwar.DTO
{
	public record MatchData
	{
		[Required] public int BeerOneId { get; set; }
		[Required] public int BeerTwoId { get; set; }
		[Required] public Guid MatchId { get; set; }
		[Required] public string ImageUrlOne { get; set; }
		[Required] public string ImageUrlTwo { get; set; }

		public MatchData(Match match)
		{
			BeerOneId = match.DuelantOneId;
			ImageUrlOne = match.BeerOne.ImageSource;
			ImageUrlTwo = match.BeerTwo.ImageSource;
			BeerTwoId = match.DuelantTwoId;
			MatchId = match.Id;
		}
	}
}
