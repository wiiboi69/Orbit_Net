using System.Xml.Serialization;

namespace Orbit_Launchpad_Ship_Server.API.level
{
    public class slot_level_DTO
    {
        [XmlRoot("slots")]
        public class level_slots_info
        {
            [XmlAttribute("hint")]
            public int hint { get; set; } // idk what the f is this
            [XmlAttribute("hint_start")]
            public int hint_start { get; set; } // idk what the f is this as well
            [XmlAttribute("total")]
            public int total { get; set; } // it count all of level that the search it can find
            [XmlElement("slot")]
            public List<slot_info> slots { get; set; } = new List<slot_info>();

        }
        public class slot_info
        {
            [XmlAttribute("type")]
            public string type { get; set; } = "user";
        /*    //[XmlArrayItem]
            public slot_level_info level_info { get; set; }
        }
        public class slot_level_info
        {*/
            [XmlElement("id")]
            public int level_id { get; set; }
            [XmlElement("npHandle")]
            public string npHandle { get; set; } = "";
            [XmlElement("location")]
            public misc_DTO.location_info location { get; set; } = new misc_DTO.location_info();
            [XmlElement("game")]
            public int game { get; set; }
            [XmlElement("name")]
            public string level_name { get; set; } = "";
            [XmlElement("description")]
            public string description { get; set; } = "";
            [XmlElement("rootLevel")]
            public string rootLevel { get; set; } = "";
            [XmlElement("icon")]
            public string icon { get; set; } = "";
            [XmlElement("initiallyLocked")]
            public bool initiallyLocked { get; set; }
            [XmlElement("isSubLevel")]
            public bool isSubLevel { get; set; }
            [XmlElement("isLBP1Only")]
            public bool isLBP1Only { get; set; }
            [XmlElement("shareable")]
            public int shareable { get; set; }
            [XmlElement("authorLabels")]
            public string authorLabels { get; set; } = "";
            [XmlElement("minPlayers")]
            public byte minPlayers { get; set; }
            [XmlElement("maxPlayers")]
            public byte maxPlayers { get; set; }
            [XmlElement("heartCount")]
            public int heartCount { get; set; }
            [XmlElement("thumbsup")]
            public int thumbsup { get; set; }
            [XmlElement("thumbsdown")]
            public int thumbsdown { get; set; }
            [XmlElement("averageRating")]
            public float averageRating { get; set; }
            [XmlElement("playerCount")]
            public int playerCount { get; set; }
            [XmlElement("matchingPlayers")]
            public int matchingPlayers { get; set; }
            [XmlElement("mmpick")]
            public bool mmpick { get; set; }
            [XmlElement("isAdventurePlanet")]
            public bool isAdventurePlanet { get; set; }
            [XmlElement("ps4Only")]
            public bool ps4Only { get; set; } // make this only allowd on ps4 lbp
            [XmlElement("playCount")]
            public int playCount { get; set; }
            [XmlElement("completionCount")]
            public int completionCount { get; set; }
            [XmlElement("lbp1PlayCount")]
            public int lbp1PlayCount { get; set; }
            [XmlElement("lbp1CompletionCount")]
            public int lbp1CompletionCount { get; set; }
            [XmlElement("lbp1UniquePlayCount")]
            public int lbp1UniquePlayCount { get; set; }
            [XmlElement("lbp2PlayCount")]
            public int lbp2PlayCount { get; set; }
            [XmlElement("lbp2CompletionCount")]
            public int lbp2CompletionCount { get; set; }
            [XmlElement("uniquePlayCount")]
            public int uniquePlayCount { get; set; }
            [XmlElement("lbp3PlayCount")]
            public int lbp3PlayCount { get; set; }
            [XmlElement("lbp3CompletionCount")]
            public int lbp3CompletionCount { get; set; }
            [XmlElement("lbp3UniquePlayCount")]
            public int lbp3UniquePlayCount { get; set; }
        }
    }
}
