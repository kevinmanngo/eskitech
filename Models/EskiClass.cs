using System.Text.Json.Serialization;

namespace eskitech.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EskiClass
    {
        TwintipSkidor = 1,
        Langdskidor = 2,
        Slalompjaxor = 3
    }
}