using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace Interview.Authentication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AuthenticateController : ApiController
    {

        // GET api/authenticate?username="a@gmail.com"&password="123"
        public JsonResult<AuthResponse> Get([FromUri] string username, [FromUri] string password)
        {
            if (username == "cnu@gmail.com" && password == "cnu")
            {
                return Json(new AuthResponse {Status = "SUCCESS"});
            }
            return Json(new AuthResponse { Status = "FAIL" });
        }
    }

    public class AuthResponse
    {
        public string Status { get; set; }
    }
}
