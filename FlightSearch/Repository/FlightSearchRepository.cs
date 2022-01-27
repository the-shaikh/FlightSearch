using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlightSearch.DTO;
using FlightSearch.Models;

namespace FlightSearch.Repository
{
    public class FlightSearchRepository
    {
        public List<FlightSearchResponseDTO> PerformFlightSearch()
        {
            List<FlightSearchResponseDTO> FlightSearchResponseResults = new List<FlightSearchResponseDTO>();

            using(Flight_DataEntities entity = new Flight_DataEntities())
            {
                try
                {
                    var tempResults = (from f in entity.FLIGHTS
                                       join a in entity.AIRLINEs on f.AIRLINE equals a.AIRLINEID
                                       join origin in entity.LOCATIONs on f.ORIGIN equals origin.LOCATIONID
                                       join destination in entity.LOCATIONs on f.DESTINATION equals destination.LOCATIONID
                                       select new
                                       {
                                           FLIGHTID = f.FLIGHTID,
                                           FLIGHTNUMBER = f.FLIGHTNUMBER,
                                           AVAILABLESEATS = f.AVAILABLESEATS,
                                           PRICE = f.PRICE,
                                           AIRLINECODE = a.AIRLINECODE,
                                           AIRLINENAME = a.AIRLINENAME,
                                           ORIGIN = origin.LOCATIONCODE,
                                           DESTINATION = destination.LOCATIONCODE,
                                           DEPARTUREDATE = f.DEPRATUREDATE,
                                           ARRIVALDATE = f.ARRIVALDATE,
                                           DURATION = f.DURATION,
                                       }).ToList();

                    foreach (var result in tempResults)
                    {
                        FlightSearchResponseDTO FlightSearchResponse = new FlightSearchResponseDTO()
                        {
                            FlightId = result.FLIGHTID,
                            FlightNumber = result.FLIGHTNUMBER,
                            AvailableSeats = result.AVAILABLESEATS,
                            AirlineCode = result.AIRLINECODE,
                            AirlineName = result.AIRLINENAME,
                            Price = result.PRICE,
                            OriginLocation = result.ORIGIN,
                            DestinationLocation = result.DESTINATION,
                            Duration = result.DURATION,
                            DepartureDate = result.DEPARTUREDATE,
                            ArrivalDate = result.ARRIVALDATE

                        };

                        FlightSearchResponseResults.Add(FlightSearchResponse);

                    }
                }
                catch(Exception ex)
                {

                }
            }

            return FlightSearchResponseResults;
        }
    }
}