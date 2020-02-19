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
        public int Id;
        public int Zipcode;
        public int Balance;
        public int Phonenumber;
        public int Startdate; // DateTime struct
        public int Enddate;   // DateTime struct
        public int Streetaddress;
        public string Name;
        public string Streetname;
        public string Cityname;
        public string Statename;
        public string Pickupday; //The day of the week for the pickup (Mon,Tues,Wed, etc...)
    }
}
