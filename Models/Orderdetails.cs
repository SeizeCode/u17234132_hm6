using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hm6.Models
{
    public class Orderdetails
    {
        public IEnumerable<order> orders { get; set; }
        public IEnumerable<order_items> order_Items { get; set; }
    }
}