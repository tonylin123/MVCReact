using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCData.Models
{
    public class Country
    {
        public Country()
        {

        }

        public Country(string name)
        {
            Name = name;
        }

        [Key]
     
        public int ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<City> Cities { get; set; } = new List<City>();
    }
}
