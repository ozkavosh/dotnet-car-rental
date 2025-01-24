using Newtonsoft.Json;

namespace Bigger.CrudCars.Application.DTOs
{
    public class BaseDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("created-at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated-at")]
        public DateTime? UpdatedAt { get; set; }
    }
}
