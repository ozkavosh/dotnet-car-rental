using Newtonsoft.Json;

namespace Bigger.CrudCars.Application.DTOs
{
    public class CarResponseDto : BaseDto
    {
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("brand")]
        public string Brand { get; set; }
        [JsonProperty("year")]
        public int Year { get; set; }
    }
}
