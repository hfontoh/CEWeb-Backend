using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEWeb.Models
{
    public class Reservation
    {
        
        public int reservationId { get; set; }
        public DateTime pick_upTime { get; set; }
        public string pick_upAddress { get; set; }
        public string destinationAddress { get; set; }
        public DateTime timeCreated { get; set; }
        public bool reservation_Cancelled { get; set; }

        public enum STATUS { WAITING, PICKEDUP, COMPLETED, CANCELLED }

        public virtual Vehicle Vehicle { get; set; }

        public virtual User User { get; set; }

        
  


    }
}
