using Beerwar.Model;

namespace Beerwar.Services.Interfaces;

public interface IMatchMaking
{
    Match CreateMatch();
    void UpdateMatch(Match match, Beer winner);
    Match GetMatch(int id);
}