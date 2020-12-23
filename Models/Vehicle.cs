using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEWeb.Models
{
    public class Vehicle
    {
        public int car_Id { get; set; }
        public string car_Make { get; set; }
        public string car_Model { get; set; }
        public string car_Year { get; set; }
        public string car_Licence_No { get; set; }
        public string car_Color { get; set; }
        public int user_Id { get; set; }
    }
}
