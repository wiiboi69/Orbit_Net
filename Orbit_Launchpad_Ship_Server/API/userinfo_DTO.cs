using System.Xml.Serialization;
using static Orbit_Launchpad_Ship_Server.API.misc_DTO;

namespace Orbit_Launchpad_Ship_Server.api
{
    public class npHandle_info
    {
        [XmlAttribute("icon")]
        public string icon { get; set; } = "";
        [XmlText]
        public string npHandle { get; set; } = "";
    }
    [XmlRoot("user")]
    public class userinfo_DTO
    {
        [XmlAttribute("type")]
        public string? Type { get; set; }
        [XmlElement("npHandle")]
        public npHandle_info npHandle { get; set; } = new npHandle_info();
        [XmlElement("game")]
        public int Game_type { get; set; } // Todo: make enum and xml do not like enums in it
        [XmlElement("lbp1UsedSlots")]
        public int lbp1_Used_Slot_Count { get; set; }
        [XmlElement("entitledSlots")]
        public int Entitled_Slot_Count { get; set; }
        [XmlElement("freeSlots")]
        public int Free_Slot_Count { get; set; } = 100;
        [XmlElement("crossControlUsedSlots")]
        public int crossControlUsedSlots { get; set; }
        [XmlElement("crossControlEntitledSlots")]
        public int crossControlEntitledSlots { get; set; }
        [XmlElement("crossControlPurchsedSlots")]
        public int crossControlPurchsedSlots { get; set; }
        [XmlElement("crossControlFreeSlots")]
        public int crossControlFreeSlots { get; set; } = 100;
        [XmlElement("lbp2UsedSlots")]
        public int lbp2_Used_Slot_Count { get; set; }
        [XmlElement("lbp2entitledSlots")]
        public int lbp2_Entitled_Slot_Count { get; set; }
        [XmlElement("lbp2PurchasedSlots")]
        public int lbp2PurchasedSlots { get; set; }
        [XmlElement("lbp2FreeSlots")]
        public int lbp2FreeSlots { get; set; } = 100;
        [XmlElement("lbp3UsedSlots")]
        public int lbp3UsedSlots { get; set; }
        [XmlElement("lbp3EntitledSlots")]
        public int lbp3EntitledSlots { get; set; }
        [XmlElement("lbp3PurchasedSlots")]
        public int lbp3PurchasedSlots { get; set; }
        [XmlElement("lbp3FreeSlots")]
        public int lbp3FreeSlots { get; set; } = 100;
        [XmlElement("lists")]
        public int lists { get; set; } // Todo: find out wtf is this
        [XmlElement("lists_quota")]
        public int lists_quota { get; set; }
        [XmlElement("heartCount")]
        public int heartCount { get; set; }
        [XmlElement("planets")]
        public string planets { get; set; } = "";
        [XmlElement("yay2")]
        public string yay2 { get; set; } = "";
        [XmlElement("boo2")]
        public string boo2 { get; set; } = "";
        [XmlElement("biography")]
        public string user_bio { get; set; } = "";
        [XmlElement("reviewCount")]
        public int reviewCount { get; set; }
        [XmlElement("commentCount")]
        public int commentCount { get; set; }
        [XmlElement("photosByMeCount")]
        public int photosByMeCount { get; set; }
        [XmlElement("commentsEnabled")]
        public bool commentsEnabled { get; set; } = true;
        [XmlElement("location")]
        public location_info location { get; set; } = new location_info();
        [XmlElement("favouriteSlotCount")]
        public int favouriteSlotCount { get; set; }
        [XmlElement("favouriteUserCount")]
        public int favouriteUserCount { get; set; }
        [XmlElement("lolcatftwCount")]
        public int lolcatftwCount { get; set; }
        [XmlElement("pins")]
        public List<int> pins { get; set; } = new List<int>();
        [XmlElement("staffChallengeGoldCount")]
        public int staffChallengeGoldCount { get; set; }
        [XmlElement("staffChallengeSilverCount")]
        public int staffChallengeSilverCount { get; set; }
        [XmlElement("staffChallengeBronzeCount")]
        public int staffChallengeBronzeCount { get; set; }
        [XmlElement("clientsConnected")]
        public client_Connected_info clientsConnected { get; set; } = new client_Connected_info();
    }
    
    public class client_Connected_info
    {
        [XmlElement("lbp1")]
        public bool lbp1 { get; set; }
        [XmlElement("lbp2")]
        public bool lbp2 { get; set; }
        [XmlElement("lbpme")]
        public bool lbpme { get; set; } // Website for lbp
        [XmlElement("lbp3ps3")]
        public bool lbp3ps3 { get; set; }
        [XmlElement("lbp3ps4")]
        public bool lbp3ps4 { get; set; }
    }
}