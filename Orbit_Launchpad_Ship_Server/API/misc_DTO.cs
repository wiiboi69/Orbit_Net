using System.Xml.Serialization;

namespace Orbit_Launchpad_Ship_Server.API
{
    public class misc_DTO
    {
        public class location_info
        {
            [XmlElement("x")]
            public int x_pos { get; set; } = 0;
            [XmlElement("y")]
            public int y_pos { get; set; } = 0;
        }
    }
}
