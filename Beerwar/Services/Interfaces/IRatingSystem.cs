using Beerwar.Model;

namespace Beerwar.Services.Interfaces.Services;

public interface IRatingSystem
{
    void ExpectedValue(MatchMakingModel match);
    void UpdateScore(MatchMakingModel match);
}