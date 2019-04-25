using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class RefereeFee
    {
        public int Id { get; set; }

        public string RefereeFeeName { get; set; }

        public string RefereeFeeCategory { get; set; }

        public int? RefereeFeeValue { get; set; }

    }
}
