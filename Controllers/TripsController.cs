using Microsoft.AspNetCore.Mvc;
using Trips.Data;

namespace Trips.Controllers{
    [Route("api/[controller]")]
    public class TripsController : Controller{
        // we need to use the constructor to inject the depency to use the service methods 

        private ITripService _service;
        public TripsController(ITripService service)
        {
           _service = service; 
        }

        [HttpGet("GetTrip/{id}")]
        public IActionResult GetTrip(int id){
           var trip=  _service.GetTripById(id);
            return Ok(trip);
        }
        [HttpGet("GetTrips")]
        public IActionResult GetTrips(){
            var trips = _service.GetAllTrips();
            return Ok(trips);
        }

        // now we will make our endpoints 
        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody]Trip trip){
            if(trip!= null){
                _service.AddTrip(trip);    
            }
            
            return Ok();

        }

        [HttpPut("UpdateTrip/{id}")]
        public IActionResult UpdateTrip(int id,[FromBody]Trip trip){
            _service.UpdateTrip(id,trip);
            return Ok();
        }
        
        [HttpDelete("DeleteTrip/{id}")]
        public IActionResult DeleteTrip(int id){
            _service.DeleteTrip(id);
            return Ok();
        }
    }
}