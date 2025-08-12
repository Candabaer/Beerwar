using System.ComponentModel.DataAnnotations;

namespace Beerwar.DTO;

public class MatchWinner
{
    [Required]
    public Guid MatchId { get; set; }
    [Required]
    public int WinnerId { get; set; }
}