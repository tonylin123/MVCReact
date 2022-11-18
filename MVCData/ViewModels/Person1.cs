namespace MVCData.ViewModels
{
    public class Person1
    {
        public Person1(string name, string phone, string city)
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
