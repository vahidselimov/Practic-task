using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_task.Models
{
    class Order
    {
        public int Id { get; set; }
        public List<OrderItem> orderItems { get; set; }
        public double Totalprice { get; set; }

    }
}
