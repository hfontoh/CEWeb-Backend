using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEWeb.Models
{
    public class User
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string email { get; set; }

        //public bool driver { get; set; }

        //public virtual Reservation Reservation { get; set; }

    }
}

