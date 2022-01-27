using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightSearch.DTO;
using FlightSearch.Repository;

namespace FlightSearch.Controllers
{
    public class FlightSearchController : ApiController
    {

        private FlightSearchRepository _flightSearchRepository;
        public FlightSearchController()
        {
            _flightSearchRepository = new FlightSearchRepository();
        }


        [AcceptVerbs("GET")]
        public List<FlightSearchResponseDTO> FlightSearch()
        {
            List<FlightSearchResponseDTO> FlightSearchResponseResults = new List<FlightSearchResponseDTO>();

            FlightSearchResponseResults = _flightSearchRepository.PerformFlightSearch();

            return FlightSearchResponseResults;
        }
    }
}
