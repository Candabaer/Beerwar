using Beerwar.Model;
using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Services;

public class EloSystem : IRatingSystem
{
    public void ExpectedValue(MatchMakingModel match)
    {
        throw new NotImplementedException();
    }

    public void UpdateScore(MatchMakingModel match)
    {
        throw new NotImplementedException();
    }
}