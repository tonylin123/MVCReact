namespace MVCData.ViewModels
{
    public static class PeopleData
    {
        public static List<Person1> List { get; set; } = new List<Person1>()
        {
            new Person1("Thor Odinson", "0123 456789", "New Asgard"),
            new Person1("Erik Selvig", "1234 567890", "Stockholm"),
            new Person1("Darcy Lewis", "2345 678901", "New York"),
            new Person1("Jane Foster", "3456 789012", "New York"),
            new Person1("Loki Odinson", "4567 890123", "Valhalla"),
        };
    }
}
