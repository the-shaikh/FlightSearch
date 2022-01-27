using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using FlightSearch.DTO;
using FlightSearch.Repository;
using Swashbuckle.Swagger;
using FlightSearch.Authenticate;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Any;

namespace FlightSearch.Controllers
{
    public class FlightSearchController : ApiController
    {

        private FlightSearchRepository _flightSearchRepository;
        /// <summary>
        /// Constructor
        /// </summary>
        public FlightSearchController()
        {
            _flightSearchRepository = new FlightSearchRepository();
        }

        /// <summary>
        /// Perform flight search for criteria
        /// </summary>
        /// <returns>List of available flights</returns>
        [CustomAuthenticationFilter]
        [AcceptVerbs("GET")]
        public List<FlightSearchResponseDTO> FlightSearch()
        {
            List<FlightSearchResponseDTO> FlightSearchResponseResults = new List<FlightSearchResponseDTO>();

            FlightSearchResponseResults = _flightSearchRepository.PerformFlightSearch();

            return FlightSearchResponseResults;
        }

        
    }
}
