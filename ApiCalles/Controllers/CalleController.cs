using ApiCalles.DTO;
using ApiCalles.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiCalles.Controllers
{
    public class CalleController : ApiController
    {
        private CalleService calleService;
        public CalleController()
        {
            calleService = new CalleService();
        }

        [HttpPost]
        public IHttpActionResult insertar()
        {
    
            //CalleDTO calle = calleService.insertar();
            return Ok("correcto");
        }
    }
}
