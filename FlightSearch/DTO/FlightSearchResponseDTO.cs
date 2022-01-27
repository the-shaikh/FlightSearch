using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightSearch.DTO
{
    public class FlightSearchResponseDTO
    {
        public int FlightId { get; set; }
        public int? FlightNumber { get; set; }
        public int? AvailableSeats { get; set; }
        public string AirlineCode { get; set; }
        public string AirlineName { get; set; }
        public string OriginLocation { get; set; }
        public string DestinationLocation { get; set; }
        public decimal? Price { get; set; }
        public string Duration { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
    }
}