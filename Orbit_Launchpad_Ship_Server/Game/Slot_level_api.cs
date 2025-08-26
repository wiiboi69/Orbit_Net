using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Orbit_Launchpad_Ship_Server.Game
{
    public class Slot_level_api : ControllerBase
    {
        // /slots/search?pageStart=1&pageSize=30&query=)
        // /slots/by?u=domestic-career5&pageStart=1&pageSize=1000&gameFilterType=both
        // /slots/lbp2luckydip?pageStart=1&pageSize=30&gameFilterType=both&seed=13
        // /slots/mmpicks?pageStart=1&pageSize=30&gameFilterType=both&players=1&move=true
        [HttpGet]
        [Route("/slots/by")]
        public object slots_by(string u = "", int pageStart = 1, int pageSize = 30, string gameFilterType = "")
        {
            Response.ContentType = "text/xml";

            return new API.level.slot_level_DTO.level_slots_info
            {
                hint = 0,
                hint_start = 0,
                total = 1,
                slots = new List<API.level.slot_level_DTO.slot_info>
                {
                    new API.level.slot_level_DTO.slot_info
                    {
                        level_id = 4,
                        npHandle = u,
                        level_name = "twerk vod",
                        description = "twerk vod",
                        rootLevel = "test_data"
                    }
                }
            };
        }
        [HttpGet]
        [Route("/slots/search")]
        public object slots_search(int pageStart = 1, int pageSize = 30, string query = "")
        {
            Response.ContentType = "text/xml";

            return new API.level.slot_level_DTO.level_slots_info
            {
                hint = 0,
                hint_start = 0,
                total = 1,
                slots = new List<API.level.slot_level_DTO.slot_info>
                {
                    new API.level.slot_level_DTO.slot_info
                    {
                        level_id = 4,
                        npHandle = "domestic-career5",
                        level_name = "twerk vod",
                        description = "twerk vod",
                        rootLevel = "test_data"

                    }
                }
            };
        }
    }
}
