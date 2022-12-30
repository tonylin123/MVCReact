using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCData.ViewModels;
using MVCData.Models;
using MVCData.Data;
using MVCData.Models.DTOs;
using System;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace MVCData.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class Cities : ControllerBase
    {
        private readonly ApplicationDBContext Database;

        public Cities(ApplicationDBContext database)
        {
            Database = database;
        }


        public IQueryable<CityDTO> GetAll()
        {
            var cities = from city in Database.Cities
                         select new CityDTO()
                         {
                             ID = city.ID,
                             Name = city.Name,
                         };

            return cities;
        }

    }
}
