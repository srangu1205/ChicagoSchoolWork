using ChicagoSchoolsAPI.Helper;
using ChicagoSchoolsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChicagoSchoolsAPI.Controllers
{
    //https://localhost:44304/api/SchoolProfile?type=xml
    //https://localhost:44304/api/SchoolProfile?type=json
    public class SchoolProfileController : ApiController
    {
   
        /// <summary>
        /// to get student percentage values of each school.
        /// </summary>
        /// <returns>avarage percentage of schools.</returns>
        [HttpGet]
        public IHttpActionResult GetSchoolResults()
        {
            try
            {
                var schoolPercentageResults = APIClient.GetStudentPercentages();
                return Ok(schoolPercentageResults);
            }
            catch(Exception ex)
            {
                // log to the logfile/DB.
                return Content(HttpStatusCode.InternalServerError, "Internal server error");
            }
        }
   
    }
}
