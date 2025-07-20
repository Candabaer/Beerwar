using Beerwar.Database;
using Beerwar.Model;
using Beerwar.Services.Interfaces;
using Beerwar.Services.Interfaces.Services;

namespace Beerwar.Services;

public class MatchMaker(BeerwarContext context, IRatingSystem ratingSystem) : IMatchMaking
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
        ratingSystem.UpdateScore(match);
        context.MatchMaking.Update(match);
        
        context.SaveChanges();
    }
}