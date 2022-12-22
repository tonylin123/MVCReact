using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCData.Models;


namespace MVData.ViewModels
{
    public class CreateLanguageViewModel
    {
        [Required]
        [Display(Name = "Name of language")]
        public string Name { get; set; } = string.Empty;
    }
}
