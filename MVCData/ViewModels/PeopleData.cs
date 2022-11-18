namespace MVCData.ViewModels
{
    public static class PeopleData
    {
        public static List<Person1> List { get; set; } = new List<Person1>()
        {
            new Person1("Jake Paul", "1232", "ManCity"),
            new Person1("Tony Stark", "12345", "Gothenburg"),
            new Person1("Captain America", "3213213", "NewYork"),
            new Person1("Flash Man", "312312", "Washington"),
            
        };
    }
}
