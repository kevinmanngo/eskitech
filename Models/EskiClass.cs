using System.Text.Json.Serialization;

namespace eskitech.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EskiClass
    {
        ValjKategori = 0,
        Skidor = 1,
        Stavar = 2,
        Pjaxor = 3,
        Goggles = 4
    }
}