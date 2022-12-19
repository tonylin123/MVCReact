using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCData.Models;

namespace MVCData.ViewModels
{
    public class UpdatePersonViewModel
    {
       
        [Required]
        
        public int ID { get; set; } = 0;
        

        [Required]
        [Display(Name = "Enter your name")]
        public string Name { get; set; } = string.Empty;


        [Required]
        [Display(Name = "Telephone numbers")]
        public string Phone { get; set; } = string.Empty;


        [Required]
       
        [Display(Name = "Enter your city")]
        public int City { get; set; }
        public SelectList? SelectCity { get; set; }



    }

}
