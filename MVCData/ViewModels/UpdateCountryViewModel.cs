using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCData.Models;

namespace MVCData.ViewModels
{
    public class UpdateCountryViewModel
    {
       
        [Required]
       
        public int ID { get; set; } = 0;

        [Required]
        [Display(Name = "Name of country")]
        public string Name { get; set; } = string.Empty;
    }
}
