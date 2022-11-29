using System;



namespace MVCData.ViewModels
{
    public class ViewModelsContainer 
    {
        public PeopleViewModel People { get; set; } = new();
        public CreatePersonViewModel CreatePerson { get; set; } = new();
        public CountriesViewModel Countries { get; set; } = new();
        public CitiesViewModel Cities { get; set; } = new();
        public LanguagesViewModel Languages { get; set; } = new();
    }
}
