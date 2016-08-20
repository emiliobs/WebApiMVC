using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace WebApiMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HttpClientView()
        {
            List<UserTable> lstUser = new List<UserTable>();
            HttpClient client = new HttpClient();
            var result = client.GetAsync("http://localhost:7147/api/WebAPI").Result;
            if (result.IsSuccessStatusCode)
            {
                lstUser = result.Content.ReadAsAsync<List<UserTable>>().Result;
            }
            return View(lstUser);
        }
    }
}