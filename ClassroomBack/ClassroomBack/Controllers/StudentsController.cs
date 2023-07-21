using ClassRoomBackDomain.Dtos;
using ClassRoomBackDomain.Interfaces;
using ClassRoomBackDomain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentsRepository;

        public StudentsController(IStudentRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        [HttpGet]
        [Route("/ListAll")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<StudentResponseModelDTO>))]
        public IActionResult ListAll()
        {
            List<StudentResponseModelDTO> students = _studentsRepository.ListAll();

            return Ok(students);
        }

    }
}
