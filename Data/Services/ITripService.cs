
using System.Collections.Generic;

namespace Trips.Data{

    public interface ITripService{
        //here we will define all our methods that we will use for CRUD 
        //Below method is for fecthing all trips 
        List<Trip> GetAllTrips();

        //for fetching trip by Id

        Trip GetTripById(int tripId);

        //updating trip 
        void UpdateTrip (int tripId,Trip trip);

        //Deleting trip
        void DeleteTrip(int tripId);

        //adding a trip 
        void AddTrip(Trip trip);

    }
}