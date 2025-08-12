using Beerwar.Database;
using Beerwar.DTO;
using Beerwar.Model;
using Beerwar.Services.Interfaces;
using Beerwar.Services.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Beerwar.Controllers;

[Route("api/[controller]")]
public class MatchController(IMatchMaking matchMaking, IRatingSystem ratingSystem, BeerwarContext dbContext) : ControllerBase
{
	
    // GET
    [HttpGet("create")]
    public async Task<ActionResult<MatchData>> CreateMatch()
    {
        Match match = matchMaking.CreateMatch();
        dbContext.MatchMaking.Add(match);
        match.ExpectedWinProbability = ratingSystem.ExpectedValue(match);
        match.ExpectedLoseProbability = 1 - match.ExpectedWinProbability;
        await dbContext.SaveChangesAsync();
        return Ok(new MatchData(match));
    }
    
    [HttpPost("finalize")]
    public IActionResult SetWinner([FromBody] MatchWinner result)
    {
        Match match = dbContext.MatchMaking.First(m => m.Id == result.MatchId);
        match.WinnerId = result.WinnerId;
        ratingSystem.UpdateScore(match);
        dbContext.MatchMaking.Update(match);
        
        return Ok();
    }
    
    
}