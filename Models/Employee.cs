using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjTrashCollection.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public int Zipcode { get; set; }

        [ForeignKey("UserIdentity")]
        public string IdentityUserId { get; set; }
        public IdentityUser UserIdentity { get; set; }
    }
}
