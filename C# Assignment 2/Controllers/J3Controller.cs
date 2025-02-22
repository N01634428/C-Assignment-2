using Microsoft.AspNetCore.Mvc;

namespace C__Assignment_2.Controllers
{
    [ApiController]
    [Route("api/J3")]
    public class J3Controller : ControllerBase
    {
        [HttpGet("BestDays")]
        public ActionResult<string> GetBestDays([FromQuery] string[] availability)
        {
            int day1Count = 0;
            int day2Count = 0;
            int day3Count = 0;
            int day4Count = 0;
            int day5Count = 0;

            int perIn = 0;

            while (perIn < availability.Length)
            {
                string perAva = availability[perIn];

                if (perAva[0] == 'Y')
                    day1Count++;
                if (perAva[1] == 'Y')
                    day2Count++;
                if (perAva[2] == 'Y')
                    day3Count++;
                if (perAva[3] == 'Y')
                    day4Count++;
                if (perAva[4] == 'Y')
                    day5Count++;

                perIn++;
            }

            int maxAttendence = day1Count;
            if (day2Count > maxAttendence)
                maxAttendence = day2Count;
            if (day3Count > maxAttendence)
                maxAttendence = day3Count;
            if (day4Count > maxAttendence)
                maxAttendence = day4Count;
            if (day5Count > maxAttendence)
                maxAttendence = day5Count;

            var bestDays = new List<int>();
            if (day1Count == maxAttendence)
                bestDays.Add(1);
            if (day2Count == maxAttendence)
                bestDays.Add(2);

            if (day3Count == maxAttendence)
                bestDays.Add(3);

            if (day4Count == maxAttendence)
                bestDays.Add(4);

            if (day5Count == maxAttendence)
                bestDays.Add(5);

            string result = string.Join(",", bestDays);
            return result;


        }
    }
}