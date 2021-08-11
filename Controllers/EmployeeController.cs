using Assignment_3_BasicAuthenticationWEBAPI.Models;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Assignment_3_BasicAuthenticationWEBAPI.Controllers
{
    public class EmployeeController : ApiController
    {
        [BasicAuthentication]
        public HttpResponseMessage GetEmployees()
        {
            string username = Thread.CurrentPrincipal.Identity.Name;
            var EmpList = new EmployeeBL().GetEmployees();
            switch (username.ToLower())
            {
                case "maleuser":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Gender.ToLower() == "male").ToList());
                case "femaleuser":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Gender.ToLower() == "female").ToList());
                case "marketing":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Dept.ToLower() == "marketing").ToList());
                case "it":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Dept.ToLower() == "it").ToList());
                case "hr":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Dept.ToLower() == "hr").ToList());
                case "technical":
                    return Request.CreateResponse(HttpStatusCode.OK,
                        EmpList.Where(e => e.Dept.ToLower() == "technical").ToList());
                default:
                    return Request.CreateResponse(HttpStatusCode.BadRequest);

            }
        }
    }
}