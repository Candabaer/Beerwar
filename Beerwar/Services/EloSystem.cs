using Beerwar.Model;
using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Services;

public class EloSystem : IRatingSystem
{
    public double ExpectedValue(Match match)
    {
        var exponent = (match.BeerOne.Rating - match.BeerTwo.Rating) / 400;
        var denominator = 1 + Math.Pow(10, exponent);
        return 1 / denominator;
    }

    public void UpdateScore(Match match)
    {
        var winner = match.GetWinner(true);
        var loser = match.GetWinner(false);
        
        if (winner.Rating >= loser.Rating)
        {
            winner.Rating = (int)Math.Round(32 * (1 - match.ExpectedWinProbability));
            loser.Rating = (int)Math.Round(32 * (0 - match.ExpectedLoseProbability));
        }
        else
        {
            winner.Rating = (int)Math.Round(32 * (1 - match.ExpectedLoseProbability));
            loser.Rating = (int)Math.Round(32 * (0 - match.ExpectedWinProbability));
        }
    }
}