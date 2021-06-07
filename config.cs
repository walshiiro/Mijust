using Newtonsoft.Json;

namespace Mijustbotx
{
    public struct configjson
    {
        [JsonProperty("token")]
        public string Token { get; private set; }
        [JsonProperty("prefix")]
        public string Prefix { get; private set; }
        
    }
}