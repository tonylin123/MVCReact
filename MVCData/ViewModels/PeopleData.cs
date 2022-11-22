namespace MVCData.ViewModels
{
    public static class PeopleData
    {
        public static List<Person> List { get; set; } = new List<Person>()
        {
            new Person("Jake Paul", "1232", "ManCity"),
            new Person("Tony Stark", "12345", "Gothenburg"),
            new Person("Captain America", "3213213", "NewYork"),
            new Person("Flash Man", "312312", "Washington"),
            
        };
    }
}
