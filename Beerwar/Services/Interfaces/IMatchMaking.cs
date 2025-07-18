using Beerwar.Model;

namespace Beerwar.Services.Interfaces;

public interface IMatchMaking
{
    MatchMakingModel GetMatch();
}