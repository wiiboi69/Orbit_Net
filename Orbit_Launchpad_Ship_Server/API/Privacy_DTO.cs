using System.Xml.Serialization;

namespace Orbit_Launchpad_Ship_Server.api
{
    [XmlRoot("privacySettings")]
    public class PrivacySettings
    {
        [XmlElement("levelVisibility")]
        public string LevelVisibility { get; set; } = "";

        [XmlElement("profileVisibility")]
        public string ProfileVisibility { get; set; } = "";
    }
}
