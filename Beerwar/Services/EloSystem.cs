using Beerwar.Model;
using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Services;

public class EloSystem : IRatingSystem
{
    public void ExpectedValue(Match match)
    {
        throw new NotImplementedException();
    }

    public void UpdateScore(Match match)
    {
        throw new NotImplementedException();
    }
}