using ClassRoomBackDomain.Dtos;
using ClassRoomBackDomain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ClassRoomBackDomain.Repository.StudentsRepository _studentsRepository;

        public StudentsController(ClassRoomBackDomain.Repository.StudentsRepository studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        [HttpGet]
        [Route("/ListAll")]
        public List<StudentResponseModelDTO> ListAll()
        {
            return _studentsRepository.ListAll();
        }

    }
}
