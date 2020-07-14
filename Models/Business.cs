using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace LocalLookupAPI.Models
{
    public class Business
    {
        public int BusinessId { get; set; }
        [Required]
        public string Name { get; set; }
        public int CityId{get;set;}
        public string Address{get;set;}
        public string PhoneNumber{get;set;}
        [Required]
        public string Blurb { get; set; }

    }
}