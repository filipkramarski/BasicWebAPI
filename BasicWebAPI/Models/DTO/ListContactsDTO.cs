﻿namespace BasicWebAPI.Models.DTO
{
    public class ListContactsDTO
    {
        public string ContactName { get; set; }
        public int CompanyId { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string CompanyName { get; set; }
    }
}
