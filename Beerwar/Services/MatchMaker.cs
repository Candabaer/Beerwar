using Beerwar.Database;
using Beerwar.Model;
using Beerwar.Services.Interfaces;

namespace Beerwar.Services;

public class MatchMaker(BeerwarContext context) : IMatchMaking
{
    public Match CreateMatch()
    {
        Beer contestantOne = context.Beers.OrderBy(b => b.MatchParticipation).FirstOrDefault()!;
        Beer contestantTwo = context.Beers
            .OrderBy(b => b.MatchParticipation).FirstOrDefault(b => b.Id != contestantOne.Id)!;
        Match result = new Match(contestantOne, contestantTwo);
        context.MatchMaking.Add(result);
        context.SaveChanges();
        
        return result;
    }

    public Match GetMatch(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateMatch(Match match, Beer winner)
    {
        match.WinnerId = winner.Id;
        context.MatchMaking.Update(match);
        context.SaveChanges();
    }
}