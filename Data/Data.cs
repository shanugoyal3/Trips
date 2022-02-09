using System.Collections.Generic;
using System;
namespace Trips.Data{

    public static class Data{

        public static List<Trip> Trips = new List<Trip>(){

            new Trip(){
                Id =1,
                Name="Manali",
                Description="Manali is an Awesome Place.It is a romantic place",
                DateStarted = new DateTime(2021,12,27),
                DateCompleted = null

            },
            new Trip(){
                Id =2,
                Name="Vaishno Devi",
                Description="Vaishno Devi is an Holy  Place.Maa Durga Resides Here.People can visit here only if Maa call them",
                DateStarted = new DateTime(2022,01,20),
                DateCompleted = null

            },
            new Trip(){
                Id =3,
                Name="Mumbai",
                Description="Mumbai is an Awesome Place.Bollywood Actors Live Here",
                DateStarted = new DateTime(2021,12,27),
                DateCompleted = null

            },
            new Trip(){
                Id =4,
                Name="Dhamtari",
                Description="Dhamtari is an Awesome Place.Shanu Lives Here",
                DateStarted = new DateTime(2021,12,27),
                DateCompleted = null

            }

        };
        
        
    }
}