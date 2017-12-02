using System;
using contract.Enum;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace contract
{
    public interface IService
    {
        [JsonProperty(PropertyName = "product")]
        string Product { get; set; }

        [JsonProperty(PropertyName = "version")]
        string Version { get; set; }

        [JsonProperty(PropertyName = "releaseDate")]
        DateTime ReleaseDate { get; set; }

        [JsonProperty(PropertyName = "demo")]
        bool Demo { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        ServiceId ServiceId { get; set; }
    }
}