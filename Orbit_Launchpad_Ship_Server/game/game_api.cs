using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace Orbit_Launchpad_Ship_Server.game
{
    public class game_api : ControllerBase
    {
        [Route("/login")]
        public object user_login()
        {
            Response.ContentType = "text/xml";
            string url = $"{Request.Scheme}://{Request.Host}/cdn";
            return new api.Login_DTO
            {
                TokenData = "MM_AUTH=shanzenos:0:1430199822865:1:21414:73.215.185.64:5:1e1814946bfbd08d555c22d03384d6eabd97895d",
                TitleStorageUrl = url,
            };
        }
        [HttpGet]
        [Route("/eula")]
        public string user_eula()
        {
            StringBuilder builder = new();
            builder.AppendLine("Welcome to Orbit Net server");
            builder.AppendLine("");
            builder.AppendLine("This is a custom server for lbp");
            builder.AppendLine("");
            builder.AppendLine("Have Fun!");
            return builder.ToString();
        }
    }
}
