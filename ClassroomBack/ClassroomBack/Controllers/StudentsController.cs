using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public StudentsController(IConfiguration configuration)
        {

            _configuration = configuration; 

        }

        [HttpGet]
        [Route("/ListAll")]
        public string ListAll()
        {
            return "Hi";
        }

    }
}
