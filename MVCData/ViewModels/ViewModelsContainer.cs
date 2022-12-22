using MVData.ViewModels;
using System;



namespace MVCData.ViewModels
{
    public class ViewModelsContainer 
    {
        public CountriesViewModel Countries { get; set; } = new();

        public CreateCountryViewModel CreateCountry { get; set; } = new();

        public UpdateCountryViewModel UpdateCountry { get; set; } = new();



        public CitiesViewModel Cities { get; set; } = new();

        public CreateCityViewModel CreateCity { get; set; } = new();

        public UpdateCityViewModel UpdateCity { get; set; } = new();


        public LanguagesViewModel Languages { get; set; } = new();

        public CreateLanguageViewModel CreateLanguage { get; set; } = new();

        public UpdateLanguageViewModel UpdateLanguage { get; set; } = new();



        public PeopleViewModel People { get; set; } = new();

        public CreatePersonViewModel CreatePerson { get; set; } = new();

        public UpdatePersonViewModel UpdatePerson { get; set; } = new();



        
    }
}
