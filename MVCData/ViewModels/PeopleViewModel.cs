namespace MVCData.ViewModels
{
    public class PeopleViewModel
    {
        public  List<Person> List { get; set; } = new List<Person>();

        
        public string Search { get; set; } 
    }
}
