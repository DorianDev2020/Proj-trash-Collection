using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public int Zipcode { get; set; }
        public int Balance { get; set; }
        public int StreetAddress { get; set; }
        public int PhoneNumber { get; set; }
        public int SubscriptionStartDate { get; set; }
        public int SunbscriptionEndDate { get; set; }
        public string StreetName { get; set; }
        public string CityName { get; set; }
        public string Statename { get; set; }
        public string Name { get; set; }
        public string PickupDay { get; set; }
    }
}
