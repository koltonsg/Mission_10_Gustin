using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    // api route for the bowling controller
    [Route("api/[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private BowlerDbContext _bowlerContext;
        public BowlingController(BowlerDbContext temp)
        {
            _bowlerContext = temp;
        }

        [HttpGet(Name = "GetBowler")]
        public IEnumerable<Bowlers> Get()
        {
            // filtering for just the two teams
            var bowlerList = _bowlerContext.Bowlers
                .Include(b => b.Team)
                .Where(b => b.Team.TeamName == "Sharks" || b.Team.TeamName == "Marlins") 
                .ToList();

            return
                bowlerList;


        }
    }
}
