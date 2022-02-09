using System.Collections.Generic;
using System.Linq;

namespace Trips.Data{

    public class TripService : ITripService
    { // now we are not having database so we are hardcoding data by creating data class
        public void AddTrip(Trip trip)
        {   
            // now we will add data to our object
            Data.Trips.Add(trip);
            //throw new System.NotImplementedException();
        }

        public void DeleteTrip(int tripId)

        {   var trip = Data.Trips.FirstOrDefault(n=>n.Id == tripId);
            if(trip!=null){
                Data.Trips.Remove(trip);
        }
            //throw new System.NotImplementedException();
        }

        public List<Trip> GetAllTrips()
        {
            return Data.Trips.ToList();
            //throw new System.NotImplementedException();
        }

        public Trip GetTripById(int tripId)
        {   var trip = Data.Trips.FirstOrDefault(n=>n.Id == tripId);
            return trip;
            //throw new System.NotImplementedException();
        }

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = Data.Trips.FirstOrDefault(n=> n.Id == tripId );
            if(oldTrip !=null){
                oldTrip.Name = trip.Name;
                oldTrip.Description=trip.Description;
                oldTrip.DateStarted=trip.DateStarted;
                oldTrip.DateCompleted=trip.DateCompleted;
                
            }
            //throw new System.NotImplementedException();
        }
    }
}