using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskSolving.Models;

namespace TaskSolving.Controllers
{
    public class HotelApiController : ApiController
    {

        Database1Entities db = new Database1Entities();


        [HttpGet]
        public IHttpActionResult Index()
        {
            List<Hotel> list = db.Hotels.ToList();

            return Ok(list);

        }

        [HttpPost]
        public IHttpActionResult InsertData(Hotel h)
        {
            db.Hotels.Add(h);
            db.SaveChanges();

            return Ok();
        }

    }
}
