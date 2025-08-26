using System.Xml.Serialization;

namespace Orbit_Launchpad_Ship_Server.api
{
    [XmlRoot("loginResult")]
    public class Login_DTO
    {
        [XmlElement("authTicket")]
        public string? TokenData = "MM_AUTH=";
        [XmlElement("lbpEnvVer")]
        public string? ServerBrand = "Orbit server";
        [XmlElement("titleStorageURL")]
        public string? TitleStorageUrl = null;
    }
}
