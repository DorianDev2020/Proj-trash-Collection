using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string Streetname { get; set; }
        public string Cityname { get; set; }
        public string Statename { get; set; }
        public string Pickupday { get; set; } //The day of the week for the pickup (Mon,Tues,Wed, etc...)
        
        [ForeignKey("UserIdentity")]
        public string IdentityUserId { get; set; }
        public IdentityUser UserIdentity { get; set; }
    }
   
}
