using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProPayment.Models
{
    public class PROWorkouts
    {
        public int Id { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public Sport Sport { get; set; }
        public int? SportId { get; set; }



        public double? WorkoutDuration { get; set; }

        public double? WorkoutDistance { get; set; }


    }
}
