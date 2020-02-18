using System.Linq;
using Crisis.Api.Services;
using Crisis.Combat;
using Microsoft.AspNetCore.Mvc;

namespace Crisis.Api.Controllers
{
    [ApiController]
    public class CrisisController : ControllerBase
    {
        private RollService RollService { get; set; }

        [Route("Roll")]
        public IActionResult Roll(
            [FromQuery] string characterName, 
            [FromQuery] string attributeName,
            [FromQuery] string skillName,
            [FromQuery] int difficulty = 6, 
            [FromQuery] int explodeLevel = 10, 
            [FromQuery] int onTheFlyBonus = 0,
            [FromQuery] int onTheFlySuccess = 0)
        {
            //If its not your turn you can't go.
            //TODO Allow characters to hold their turn and check here if they are in the HeldTurn Queue.
            if (AppState.CurrentCrisis.Rounds.Last().InitiativeOrder.Peek().Name != characterName) return Forbid();
            //Roll using all the appropriate elements for your character and situation.
            var turn = RollService.TakeAction(characterName, attributeName, skillName, difficulty, explodeLevel);
            //Remove the acting character from the initiative.
            AppState.CurrentCrisis.Rounds.Last().InitiativeOrder.Dequeue();
            return new ObjectResult(turn);
        }
        }
}