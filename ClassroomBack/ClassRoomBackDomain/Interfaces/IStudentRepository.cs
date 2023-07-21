using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomBackDomain.Interfaces
{
    public interface IStudentRepository
    {

        List<Dtos.StudentResponseModelDTO> ListAll();

    }
}
