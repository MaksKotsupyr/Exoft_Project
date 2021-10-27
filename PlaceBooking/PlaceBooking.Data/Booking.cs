using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlaceBooking.Data
{
    public class Booking
    {
        public int Id { get; set; }
        public WorkingPlace Place { get; set; }
        public DateTime Date { get; set; }
        public TypeOfBooking TypeOfBooking { get; set; }
        public WorkingPlaceStatus Status { get; set; }
    }
}
