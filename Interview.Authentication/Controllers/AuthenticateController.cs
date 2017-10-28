using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Interview.Authentication.Controllers
{
    public class AuthenticateController : ApiController
    {

        // GET api/authenticate?username="a@gmail.com"&password="123"
        public string Get([FromUri] string username, [FromUri] string password)
        {
            if (username == "cnu@gmail.com" && password == "cnu")
            {
                return "SUCCESS";
            }
            return "FAIL";
        }
    }
}
