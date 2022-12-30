namespace MVCData.Models.DTOs
{
    public class CountryDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<CityDTO> Cities { get; set; } = new List<CityDTO>();
    }
}
