using PlaceBooking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooking.BusinessLogic
{
    public class WorkingPlaceService : IWorkingPlaceService
    {
        List<WorkingPlace> workingPlaces = new List<WorkingPlace>  { 
            new WorkingPlace { Id = 1},
            new WorkingPlace { Id = 2},
            new WorkingPlace { Id = 3},
            new WorkingPlace { Id = 4},
            new WorkingPlace { Id = 5}
        };
        

        public List<WorkingPlace> GetAvailablePlaces(DateTime date)
        {
            var bookedPlaces = bookings.Where(x => x.Date == date && x.Status == WorkingPlaceStatus.Red).Select(x => x.Place.Id).ToList();

            return workingPlaces.Where(place => !bookedPlaces.Contains(place.Id)).ToList();
        }
        List<Booking> bookings = new List<Booking>
        {
            new Booking
            {
                Id = 1,
                Date = new DateTime(2021,10,14),
                Status = WorkingPlaceStatus.Red,
                TypeOfBooking = TypeOfBooking.Full,
                Place = new WorkingPlace
                {
                    Id = 1
                }
            }
        };

    }
}
