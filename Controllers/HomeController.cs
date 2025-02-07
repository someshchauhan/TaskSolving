using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using TaskSolving.Models;

namespace TaskSolving.Controllers
{
    public class HomeController : Controller
    {

        HttpClient client = new HttpClient();

        // GET: Home
        public ActionResult Index()
        {

            List<Hotel> li = new List<Hotel>();


            client.BaseAddress = new Uri("https://localhost:44309/api/HotelApi");

            var response = client.GetAsync("Home");

            response.Wait();

            var test = response.Result;

            if(test.IsSuccessStatusCode)
            {
                var res = test.Content.ReadAsAsync<List<Hotel>>();

                res.Wait();

                li = res.Result;

            }



            return View(li);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Hotel h)
        {
            client.BaseAddress = new Uri("https://localhost:44309/api/HotelApi");

            var response = client.PostAsJsonAsync("HotelApi", h);

            response.Wait();

            var test = response.Result;

            if(test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}