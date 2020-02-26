using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjTrashCollection.Models
{
    public class EmployeeView
    {
        public Employee Employee { get; set; }
        public Customer Customer { get; set; }
        public List<Customer> Customers { get; set; }
        public Address Address { get; set; }
        public Service ServiceInfo { get; set; }

    }
}
