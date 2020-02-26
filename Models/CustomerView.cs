using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjTrashCollection.Models
{
    public class CustomerView
    {
        public Address Address { get; set; }
        public Customer Customer { get; set; }
        public Service ServiceInfo { get; set; }
    }
}
