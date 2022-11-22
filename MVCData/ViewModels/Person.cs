namespace MVCData.ViewModels
{
    public class Person
    {
        public Person(string id,string name, string phone, string city)
        {
            Id = id;
            Name = name;
            Phone = phone;
            City = city;
        }
        public string Id { get; set; }
        public string Name { get; set; } 

        public string Phone { get; set; } 

        public string City { get; set; } 
    }
}
