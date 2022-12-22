using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCData.Models;

namespace MVCData.ViewModels
{
    public class UpdateLanguageViewModel
    {
        [HiddenInput]
        [Required]
        
        public int ID { get; set; } = 0;

        [Required]
        [Display(Name = "Name of language")]
        public string Name { get; set; } = string.Empty;
    }
}
