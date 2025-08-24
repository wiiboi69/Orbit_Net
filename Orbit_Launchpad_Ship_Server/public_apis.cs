using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Orbit_Launchpad_Ship_Server
{
    public class public_apis : ControllerBase
    {
        [HttpGet]
        [Route("/autodiscover")]
        public string autodiscover()
        {
            string url = $"{Request.Scheme}://{Request.Host}";
            return JsonConvert.SerializeObject(new patcher_api.autodiscover
            {
                url = url,
            });
        }
    }
}
