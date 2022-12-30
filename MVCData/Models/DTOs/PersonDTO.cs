namespace MVCData.Models.DTOs
{
    public class PersonDTO
    {
        public int ID { get; set; }

        public string Name { get; set; } 

        public string Phone { get; set; } 

        public string City { get; set; } 

        public List<string> Languages { get; set; } = new List<string>();
    }
}
