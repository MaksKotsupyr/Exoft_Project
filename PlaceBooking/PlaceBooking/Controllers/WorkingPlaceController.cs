using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaceBooking.BusinessLogic;
using PlaceBooking.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaceBooking.Controllers
{
    [ApiController]

    public class WorkingPlaceController : ControllerBase
    {
        private readonly IWorkingPlaceService _workingPlaceService;

        public WorkingPlaceController(IWorkingPlaceService workingPlaceService)
        {
            _workingPlaceService = workingPlaceService;
        }
        [HttpGet]
        [Route("api/working-place/place/{id}")]
        public WorkingPlace GetPlace(int id)
        {
            var place = new WorkingPlace { Id = id };
            return place;
        }

        [HttpGet]
        [Route("api/working-place/available-places/{date}")]
        public List<WorkingPlace> GetAvailablePlaces(DateTime date)
        {
            return _workingPlaceService.GetAvailablePlaces(date);

        }
    }
}
