using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace LocalLookupAPI.Models
{
    public class City
    {

        public int CityId{get;set;}
        public int ZipCode{get;set;}

        public string Name{get;set;}
        public HashSet<Business> Businesses;

    }
}