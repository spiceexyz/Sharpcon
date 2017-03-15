using Newtonsoft.Json;

namespace Sharpcon.WebSockets.CustomPackets
{
    public class Player
    {
        [JsonProperty("SteamID")]
        public string SteamId { get; set; }

        [JsonProperty("OwnerSteamID")]
        public string OwnerSteamId { get; set; }

        [JsonProperty("DisplayName")]
        public string DisplayName { get; set; }

        [JsonProperty("Ping")]
        public int Ping { get; set; }

        [JsonProperty("Address")]
        public string Address { get; set; }

        [JsonProperty("ConnectedSeconds")]
        public int ConnectedSeconds { get; set; }

        [JsonProperty("VoiationLevel")] // Not a typo, this is how Rust writes it
        public float ViolationLevel { get; set; }

        [JsonProperty("CurrentLevel")] // Obsolete, XP system no longer in use
        public float CurrentLevel { get; set; }

        [JsonProperty("UnspentXp")] // Obsolete, XP system no longer in use
        public float UnspentXp { get; set; }

        [JsonProperty("Health")]
        public float Health { get; set; }
    }
}
/*[
  {
    "SteamID": "76561198373103670",
    "OwnerSteamID": "0",
    "DisplayName": "[BAJS] <[Elizabeth Swann]>",
    "Ping": 49,
    "Address": "81.226.161.60:57021",
    "ConnectedSeconds": 25982,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 100.0
  },
  {
    "SteamID": "76561198132852177",
    "OwnerSteamID": "0",
    "DisplayName": "[BAJS] stampe",
    "Ping": 47,
    "Address": "87.241.87.176:49885",
    "ConnectedSeconds": 25963,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 100.0
  },
  {
    "SteamID": "76561197996490518",
    "OwnerSteamID": "0",
    "DisplayName": "[BAJS] TriiXXoN",
    "Ping": 45,
    "Address": "83.248.171.161:49662",
    "ConnectedSeconds": 15845,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 74.0141
  },
  {
    "SteamID": "76561198119761594",
    "OwnerSteamID": "0",
    "DisplayName": "[AGA] RooNDowN",
    "Ping": 64,
    "Address": "88.252.84.191:65177",
    "ConnectedSeconds": 9221,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 83.60152
  },
  {
    "SteamID": "76561198030178077",
    "OwnerSteamID": "0",
    "DisplayName": "DRiVER",
    "Ping": 18,
    "Address": "94.226.2.36:50505",
    "ConnectedSeconds": 4574,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 100.0
  },
  {
    "SteamID": "76561198268098965",
    "OwnerSteamID": "0",
    "DisplayName": "[YTteam] Favágó/Bérgyilkos",
    "Ping": 42,
    "Address": "176.63.61.37:61663",
    "ConnectedSeconds": 4267,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 80.9946747
  },
  {
    "SteamID": "76561198018918304",
    "OwnerSteamID": "0",
    "DisplayName": "[TAG] JammieJoe",
    "Ping": 54,
    "Address": "81.154.69.35:60096",
    "ConnectedSeconds": 4018,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 94.8731155
  },
  {
    "SteamID": "76561198062528012",
    "OwnerSteamID": "0",
    "DisplayName": "fireandice2103",
    "Ping": 43,
    "Address": "92.229.102.248:57573",
    "ConnectedSeconds": 3592,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 93.64174
  },
  {
    "SteamID": "76561198081179205",
    "OwnerSteamID": "0",
    "DisplayName": "AlisaReveN",
    "Ping": 165,
    "Address": "27.4.178.150:56025",
    "ConnectedSeconds": 2737,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 99.99937
  },
  {
    "SteamID": "76561198181583473",
    "OwnerSteamID": "0",
    "DisplayName": "[YTteam] _DeX_",
    "Ping": 42,
    "Address": "89.132.249.106:49404",
    "ConnectedSeconds": 2652,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 100.0
  },
  {
    "SteamID": "76561198002287845",
    "OwnerSteamID": "0",
    "DisplayName": "otozki",
    "Ping": 42,
    "Address": "85.76.80.207:46283",
    "ConnectedSeconds": 1320,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 100.0
  },
  {
    "SteamID": "76561198151492918",
    "OwnerSteamID": "0",
    "DisplayName": "[Dafaq] MaxFreak",
    "Ping": 121,
    "Address": "188.51.87.18:51210",
    "ConnectedSeconds": 319,
    "VoiationLevel": 0.0,
    "CurrentLevel": 0.0,
    "UnspentXp": 0.0,
    "Health": 100.0
  }
]
*/