﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVCData.ViewModels;

namespace MVCData.Models
{
    public class City
    {
        public City()
        {

        }

        public City(string name, Country country)
        {
            Name = name;
            Country = country;
        }

       

        [Key]
       
        public int ID { get; set; }

        public string Name { get; set; } 

        public List<Person> People { get; set; } = new List<Person>();

        public Country Country { get; set; } = new Country();

    }
}
