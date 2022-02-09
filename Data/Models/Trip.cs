using System;
namespace Trips.Data

{
    public class Trip {
        // we have created model for trip data
        // now we will create mock services for making api end points for CRUD Operations
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime? DateCompleted { get; set; }
    }

}