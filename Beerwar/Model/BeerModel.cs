namespace Beerwar.Model;

public class BeerModel
{
    public int Id { get; init; }
    
    public string Name { get; init; } = string.Empty;
    public string Description { get; init; } =  string.Empty;
    public string ImageSource { get; init; } = string.Empty;

    public int Rating { get; set; } = 1500;
    public int MatchParticipation { get; set; }
}