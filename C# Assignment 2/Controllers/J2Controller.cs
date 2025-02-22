using Microsoft.AspNetCore.Mvc;

namespace C__Assignment_2.Controllers
{
    [ApiController]
    [Route("api/J2")]
    public class J2Controller : ControllerBase
    {
        // API method to calculate the total SHU for the given ingredients
        [HttpGet("ChiliPeppers")]
        public int ChiliPeppers([FromQuery] string Ingredients)
        {
            int totalSHU = 0;
            string[] peppers = Ingredients.Split(',');
            int i = 0;

            while (i < peppers.Length)
            {
                string pepper = peppers[i].Trim();

                if (pepper == "Poblano")
                {
                    totalSHU = totalSHU + 1500;
                }
                else if (pepper == "Mirasol")
                {
                    totalSHU = totalSHU + 6000;
                }
                else if (pepper == "Serrano")
                {
                    totalSHU = totalSHU + 15500;
                }
                else if (pepper == "Cayenne")
                {
                    totalSHU = totalSHU + 40000;
                }
                else if (pepper == "Thai")
                {
                    totalSHU = totalSHU + 75000;
                }
                else if (pepper == "Habanero")
                {
                    totalSHU = totalSHU + 125000;
                }
                i++;


            }
            return totalSHU;
        }
    }
}