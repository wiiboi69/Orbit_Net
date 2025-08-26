using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Orbit_Launchpad_Ship_Server.api;
using System.Text;
using System.Xml.Serialization;

namespace Orbit_Launchpad_Ship_Server.game
{
    public class game_api : ControllerBase
    {
        [Route("/login")]
        public object LoginToOrbit()
        {
            Response.ContentType = "text/xml";



            string url = $"{Request.Scheme}://{Request.Host}/cdn";
            return new api.Login_DTO
            {
                TokenData = "MM_AUTH=shanzenos:0:1430199822865:1:21414:73.215.185.64:5:1e1814946bfbd08d555c22d03384d6eabd97895d",
                TitleStorageUrl = url,
            };
            // There is platform, gameid and platformid.


            // MM_AUTH : Media Molecule Auth
            // shanzenos : Username
            // 0 : ?
            // 1430199822865 : Unix Time Stamp
            // 1 : ? 
            // 21414 : ?
            // 73.215.185.64 : IP
            // 5 : ?
            // 1e1814946bfbd08d555c22d03384d6eabd97895d : Might be Platform ID
        }

        [HttpGet]
        [Route("/eula")]
        public string GetEula()
        {
            StringBuilder builder = new();
            builder.AppendLine("Welcome to Orbit Net Server!");
            builder.AppendLine("");
            builder.AppendLine("You're now connected to a custom server for LBP.");
            builder.AppendLine("");
            builder.AppendLine("Have fun, explore, and enjoy your experience!");
            return builder.ToString();
        }
        [HttpGet]
        [Route("/network_settings.nws")]
        public string Getnetwork_settingsnws()
        {
            string cdnurl = $"{Request.Scheme}://{Request.Host}/cdn";
            string url = $"{Request.Scheme}://{Request.Host}/Telemetry";

            StringBuilder builder = new();
            builder.AppendLine($"AllowOnlineCreate true");
            builder.AppendLine($"ShowErrorNumbers true");
            builder.AppendLine($"AllowModeratedLevels false");
            builder.AppendLine($"AllowModeratedPoppetItems false");
            builder.AppendLine($"ShowLevelBoos true");
            builder.AppendLine($"CDNHostName {cdnurl}");
            builder.AppendLine($"TelemetryServer {url}");
            builder.AppendLine($"OverheatingThresholdDisallowMidgameJoin 2.0");
            builder.AppendLine($"EnableCommunityDecorations true");
            builder.AppendLine($"EnablePlayedFilter true");
            builder.AppendLine($"EnableDiveIn false");
            builder.AppendLine($"EnableHackChecks false");
            builder.AppendLine($"DisableDLCPublishCheck true");
            builder.AppendLine($"AlexDB true");
            return builder.ToString();
        }

        [HttpPost]
        [Route("/match")]
        public string match()
        {
            var reader = new StreamReader(Request.Body);
            Console.WriteLine(reader.ReadToEndAsync().GetAwaiter().GetResult());

            /*
            
            [UpdateMyPlayerData,["Player":"domestic-career5","RoomState":4]]
            [UpdateMyPlayerData,["Player":"domestic-career5","RoomState":0]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[2,37],"RoomState":1,"BuildVersion":1]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[5,0]],"RoomState":0,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":0]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[0,124888],"RoomState":1]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[0,124888]],"RoomState":1,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":8]]
            [UpdateMyPlayerData,["Player":"domestic-career5","PassedNoJoinPoint":1]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":36]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":54]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[5,0],"RoomState":0,"PassedNoJoinPoint":0,"Comp":0,"BuildVersion":289]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[5,0]],"RoomState":0,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Mood":0]]
            [UpdatePlayersInRoom,["Players":["domestic-career5"],"Reservations":["0"]]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[0,156004]],"RoomState":1,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":50]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[0,124886],"RoomState":1,"Comp":0]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":11]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":22]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":12]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":50]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":100]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[5,0]],"RoomState":0,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[5,0],"RoomState":0,"Comp":0,"BuildVersion":289]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[0,124890]],"RoomState":0,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":50]]
            [UpdateMyPlayerData,["Player":"domestic-career5","PassedNoJoinPoint":1]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":33]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[0,124890]],"RoomState":0,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[0,124890],"RoomState":1,"PassedNoJoinPoint":0,"Comp":0]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":100]]
            [CreateRoom,["Players":["domestic-career5"],"Reservations":["0"],"NAT":[2],"Slots":[[0,127120]],"RoomState":0,"HostMood":0,"PassedNoJoinPoint":0,"Location":[],"Language":1,"BuildVersion":289,"Search":""]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Slot":[0,124922],"RoomState":0]]
            [UpdateMyPlayerData,["Player":"domestic-career5","Comp":0]]










             */
            return 1.ToString(); // Todo
        }
        // http://192.168.0.4/npdata


        //playersInPodCount
        [HttpGet]
        [Route("/playersInPodCount")]
        [Route("/totalPlayerCount")]
        public string TotalPlayerCount()
        {
            return 1.ToString(); // Todo
        }

        [HttpGet]
        [Route("/farc_hashes")]
        public ContentResult farc_hashes()
        {
            return new ContentResult
            {
                StatusCode = 410
            };
        }

        [HttpGet]
        [Route("/privacySettings")]
        public object PrivacySettings()
        {
            Response.ContentType = "text/xml";

            return new PrivacySettings
            {
                LevelVisibility = "all",
                ProfileVisibility = "all"
            };
        }

        [HttpGet]
        [Route("/s/user/{UsernameId}")]
        public object UserInfo_id(int UsernameId, int version = 1)
        {
            Response.ContentType = "text/xml";

            return new userinfo_DTO
            {
                user_bio = UsernameId.ToString(),
                npHandle = new npHandle_info
                {
                    icon = "",
                    npHandle = UsernameId.ToString()
                }
            };
        }

        [HttpGet]
        [Route("/user/{UsernameId}")]
        public object UserInfo(string UsernameId, int version = 1)
        {
            Response.ContentType = "text/xml";

            return new userinfo_DTO
            {
                user_bio = UsernameId,
                npHandle = new npHandle_info
                {
                    icon = "",
                    npHandle = UsernameId
                }
            };
        }
    }
}
