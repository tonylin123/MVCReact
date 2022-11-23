namespace MVCData.ViewModels
{
    public static class PeopleData
    {
        


        public static List<Person> List { get; set; } = new List<Person>()
        {
           new Person(Guid.NewGuid().ToString(),"Jake Paul", "123289", "ManCity"),
           new Person(Guid.NewGuid().ToString(), "Tony Stark", "12345", "Gothenburg"),
           new Person(Guid.NewGuid().ToString(), "Captain America", "3213213", "NewYork"),
           new Person(Guid.NewGuid().ToString(), "Flash Man", "312312", "Washington"),

        };
    }
}
