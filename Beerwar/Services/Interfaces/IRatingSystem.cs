using Beerwar.Model;

namespace Beerwar.Services.Interfaces.Services;

public interface IRatingSystem
{
    double ExpectedValue(Match match);
    void UpdateScore(Match match);
}