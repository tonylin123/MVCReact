using System;



namespace MVCData.ViewModels
{
    public class PCViewModels 
    {
        public PeopleViewModel People { get; set; } = new();
        public CreatePersonViewModel CreatePerson { get; set; } = new();
    }
}
