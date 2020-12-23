using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEWeb.Models
{
    
    public class ReservationStatus
    {
        public enum Status { AWAITING, PICKED, COMPLETED, CANCELLED };
        public int reservationStatusId { get; set; }
        public int reservationId { get; set; }
        public int user_vehicle_Id { get; set; }
        public DateTime ride_start_time { get; set; }
        public DateTime ride_drop_time { get; set; }

        public Status RideStatus { get; set; }

    }
}
