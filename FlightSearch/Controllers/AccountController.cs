using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FlightSearch.Manager;

namespace FlightSearch.Controllers
{
    public class AccountController : ApiController
    {
        /// <summary>
        /// Login here
        /// </summary>
        /// <param name="username">Enter your Username</param>
        /// <param name="password">Enter your Password</param>
        /// <returns></returns>
        //[HttpGet]
        //[Route("ValidateLogin")]
        [AcceptVerbs("GET")]
        public HttpResponseMessage ValidateLogin(string username, string password)
        {
            if(username == "admin" && password == "admin")
            {
                return Request.CreateResponse(HttpStatusCode.OK, value: TokenManager.GenerateToken(username));
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message: "Username/Password is invalie");
            }
        }


    }
}
