using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjTrashCollection.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public double Balance { get; set; }
        
        public DateTime Start { get; set; }
        
        public DateTime End { get; set; }
        
        public string PickUpDay { get; set; }
        public DateTime OneTimePickUp { get; set; }
        public bool Suspended { get; set; }
        public bool PickedUp { get; set; }
    }
}
