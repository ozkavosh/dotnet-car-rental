using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using Xunit.Sdk;

namespace Bigger.CrudCars.Application.DTOs
{
    public class CarCreateDto
    {
        [JsonProperty("model")]
        [Required(ErrorMessage = "Model is required")]
        [StringLength(50, ErrorMessage = "Model can't be longer than 50 characters")]
        public string Model { get; set; }
        [JsonProperty("brand")]
        [Required(ErrorMessage = "Brand is required")]
        [StringLength(50, ErrorMessage = "Brand can't be longer than 50 characters")]
        public string Brand { get; set; }
        [JsonProperty("year")]
        [Required(ErrorMessage = "Year is required")]
        [Range(1920, 9999, ErrorMessage = "Year must be between 1920 and the current year")]
        public int Year { get; set; }
    }
}
