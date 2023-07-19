using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BasicWebAPI.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
