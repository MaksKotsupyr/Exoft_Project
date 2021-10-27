using PlaceBooking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceBooking.BusinessLogic
{
    public interface IWorkingPlaceService
    {
        List<WorkingPlace> GetAvailablePlaces(DateTime date);
    }
}
