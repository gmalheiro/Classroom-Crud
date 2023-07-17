using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomBackDomain.Interfaces
{
    public interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        ISubjectClass Class { get; set; }
    }
}
