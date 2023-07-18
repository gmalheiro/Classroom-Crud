using ClassRoomBackDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomBackDomain.Interfaces
{
    public interface ISubjectClass
    {
        int ClassId { get; set; }
        string ClassName { get; set; }
        int StudentId { get; set; }
        ICollection<Student> Students { get; set; }
    }
}
