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