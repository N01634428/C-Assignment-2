using Microsoft.AspNetCore.Mvc;

namespace C__Assignment_2.Controllers
{

    [ApiController]
    [Route("apiJ1")]
    public class J1Controller: ControllerBase
    /// calculates the final score based on deliveries and collisions.
    /// int deliveries is number of packages delivered.
    /// int collisions is number of collisions with obstacles.
    /// returns the final number in integer.
    {
        [HttpPost("Delivedroid")]
        public int Delivedroid([FromForm] int deliveries, [FromForm] int collisions)
        {
            int score = (deliveries * 50) - (collisions * 10);
            if (deliveries > collisions)
            {
                score = score + 500;

            }
            return score;
        }


        [HttpPost("SushiCost")]
        public int SushiCost([FromForm] int redplate, [FromForm] int greenplate, [FromForm] int blueplate)
        {
            int totalCost = (redplate*3) + (greenplate*4) + (blueplate*5);
            return totalCost;
        }

    }


}
