using System.ComponentModel.DataAnnotations;

namespace MVCData.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        [Display(Name = "Enter your name")]
        public string Name { get; set; } 

        [Required]
        [Display(Name = "Telephone numbers")]
        public string Phone { get; set; } 

        [Required]
        [Display(Name = "Enter your city")]
        public string City { get; set; } 
    }
}
