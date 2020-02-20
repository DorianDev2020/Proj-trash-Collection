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
        public string PickupDay { get; set; }
        public bool IsSuspended { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime OneTimePickup { get; set; }
    }
}
