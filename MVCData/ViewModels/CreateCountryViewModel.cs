using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCData.Models;

namespace MVCData.ViewModels
{
    public class CreateCountryViewModel
    {
        [Required]
        [Display(Name = "Name of country")]
        public string Name { get; set; } = string.Empty;
    }
}
