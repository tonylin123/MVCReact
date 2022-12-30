using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCData.ViewModels;
using MVCData.Models;
using MVCData.Data;
using MVCData.Models.DTOs;
using System;

namespace MVCData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class Languages : ControllerBase
    {
        private readonly ApplicationDBContext Database;

        public Languages(ApplicationDBContext database)
        {
            Database = database;
        }


        public IQueryable<LanguageDTO> GetAll()
        {
            var languages = from l in Database.Languages
                            select new LanguageDTO()
                            {
                                ID = l.ID,
                                Name = l.Name,
                            };

            return languages;
        }

    }
}
