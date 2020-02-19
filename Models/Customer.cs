using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjTrashCollection.Models
{
    public class Customer
    {
        [Key]
        public int CustID {get; set;}

        public int Zipcode { get; set; }
        public int Balance { get; set; }
        public int Phonenumber { get; set; }
        public int Startdate { get; set; } // DateTime struct
        public int Enddate { get; set; }  // DateTime struct
        public int Streetaddress { get; set; }
        public string Name { get; set; }
        public string Streetname { get; set; }
        public string Cityname { get; set; }
        public string Statename { get; set; }
        public string Pickupday { get; set; } //The day of the week for the pickup (Mon,Tues,Wed, etc...)
    }
}
