namespace MVCData.ViewModels
{
    public class Person
    {
        public Person(string name, string phone, string city)
        {
            Name = name;
            Phone = phone;
            City = city;
        }

        public string Name { get; set; } 

        public string Phone { get; set; } 

        public string City { get; set; } 
    }
}
