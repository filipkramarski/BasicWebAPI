﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BasicWebAPI.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
