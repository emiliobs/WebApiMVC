using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiMVC.Controllers
{
    public class WebAPIController : ApiController
    {
        public HttpResponseMessage Get()
        {
            using (WebApiDBEntities db = new WebApiMVC.WebApiDBEntities ())
            {
                //List<UserTable> userlist = new List<UserTable>();
              var  userlist = db.UserTables.OrderBy(a => a.UserID).ToList();
                HttpResponseMessage response;
                response = Request.CreateResponse(HttpStatusCode.OK, userlist);
                return response;
            }
        }
    }
}
