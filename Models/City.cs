using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace LocalLookupAPI.Solution.Models
{
    public class City
    {
        public int BusinessId { get; set; }
        public int CityId{get;set;}
        public string Address{get;set;}
        public string PhoneNumber{get;set;}
        public string Blurb { get; set; }

    }
}