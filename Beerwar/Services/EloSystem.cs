using Beerwar.Model;
using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Services;

public class EloSystem : IRatingSystem
{
    public double ExpectedValue(Match match)
    {
        var exponent = (match.BeerTwo.Rating - match.BeerOne.Rating) / 400;
        var denominator = 1+ Math.Pow(10,exponent);
        return 1 / denominator;
    }

    public void UpdateScore(Match match)
    {
        match.GetWinner().Rating += 10;
        match.GetLoser().Rating -= 10;
    }
}