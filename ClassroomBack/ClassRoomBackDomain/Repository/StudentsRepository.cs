using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassRoomBackDomain.Context;
using ClassRoomBackDomain.Interfaces;

namespace ClassRoomBackDomain.Repository
{
    public class StudentsRepository : IStudentRepository
    {
        private readonly AppDbContext _context;

        
        public StudentsRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Dtos.StudentResponseModelDTO> ListAll()
        {
            return _context.Students.Select( s => new Dtos.StudentResponseModelDTO()
            {
                Name = s.Name,
                Surname = s.Surname,
                Class = s.Class.ClassName
            }).ToList();
        }

    }
}