using Beerwar.Model;

namespace Beerwar.Services.Interfaces.Services;

public interface IRatingSystem
{
    void ExpectedValue(Match match);
    void UpdateScore(Match match);
}