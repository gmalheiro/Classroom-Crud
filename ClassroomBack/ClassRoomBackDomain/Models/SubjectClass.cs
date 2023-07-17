using ClassRoomBackDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomBackDomain.Models
{
    [Table("SubjectClass")]
    public class SubjectClass : ISubjectClass
    {
        public SubjectClass()
        {
            Students = new Collection<IStudent>();
        }
        [Key]
        public int ClassId { get; set; }
        [Required]
        [StringLength(80)]
        public string? ClassName { get; set; }
        public ICollection<IStudent>? Students { get ; set ; }
    }
}
