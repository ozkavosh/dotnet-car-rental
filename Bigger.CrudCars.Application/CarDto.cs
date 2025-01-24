namespace Bigger.CrudCars.Application
{
    public class CarDto
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
    }
}
