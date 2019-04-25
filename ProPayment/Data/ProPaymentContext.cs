using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProPayment.Models;

namespace ProPayment.Models
{
    public class ProPaymentContext : DbContext
    {
        public ProPaymentContext (DbContextOptions<ProPaymentContext> options)
            : base(options)
        {
        }

        public DbSet<ProPayment.Models.CupOnlineMatch> CupOnlineMatch { get; set; }

        public DbSet<ProPayment.Models.Tournament> Tournament { get; set; }

        public DbSet<ProPayment.Models.PaymentVerification> PaymentVerification { get; set; }

        public DbSet<ProPayment.Models.Referee> Referee { get; set; }

        public DbSet<ProPayment.Models.RefereeFee> RefereeFee { get; set; }

        public DbSet<ProPayment.Models.PROMatch> PROMatch { get; set; }
    }
}
