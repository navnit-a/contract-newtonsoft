using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace contract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ServiceId
    {
        Marketing,
        Alist
    }
}