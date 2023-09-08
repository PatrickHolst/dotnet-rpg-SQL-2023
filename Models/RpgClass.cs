using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Bard = 1,
        Hantverkare = 2,
        Jägare = 3,
        Krigare = 4,
        Lärd = 5,
        Magiker = 6,
        Nasare = 7,
        Riddare = 8,
        Sjöfarare = 9,
        Tjuv = 10,


    }
}