using Newtonsoft.Json;

namespace Sharpcon
{
    public class Packet
    {
        [JsonProperty("Identifier")]
        public int Identifier { get; set; }

        [JsonProperty("Message")]
        public string Message { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        /// <summary>
        /// Packet constructor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="identifier"></param>
        /// <param name="name"></param>
        public Packet(string message, int identifier = 1, string name = "Sharpcon")
        {
            Identifier = identifier;
            Message = message;
            Name = name;
        }
    }
}
