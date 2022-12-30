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
    
    public class Countries : ControllerBase
    {
        private readonly ApplicationDBContext Database;

        public Countries(ApplicationDBContext database)
        {
            Database = database;
        }


        public IQueryable<CountryDTO> GetAll()
        {
            var countries = from country in Database.Countries
                            select new CountryDTO()
                            {
                                ID = country.ID,
                                Name = country.Name,
                                Cities = country.Cities.Select(city => new CityDTO()
                                {
                                    ID = city.ID,
                                    Name = city.Name,
                                }).ToList()
                            };

            return countries;
        }


        [HttpGet("{id}", Name = "GetCountry")]
        public IActionResult GetById(int id)
        {
            var countries = from country in Database.Countries
                            where country.ID == id
                            select new CountryDTO()
                            {
                                ID = country.ID,
                                Name = country.Name,
                                Cities = country.Cities.Select(city => new CityDTO()
                                {
                                    ID = city.ID,
                                    Name = city.Name,
                                }).ToList()
                            };

            if (countries.Any())
            {
                return new ObjectResult(countries.First());
            }
            else
            {
                return NotFound();
            }
        }

    }
}
