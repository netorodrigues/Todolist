using Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.CustomerAgg.ValueObjects
{
    public sealed record CustomerId : EntityCode<Customer>
    {
        public CustomerId(string customerId) : base(customerId)
        {
        }
        public CustomerId() : base()
        {
        }
    }
}
