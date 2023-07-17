using ClassRoomBackDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ClassRoomBackDomain.Models
{
    [Table("Students")]
    public class Student : IStudent
    {
        [Key]
        public int StudentId { get; set ; }
        [Required]
        [StringLength(80)]
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [Required]
        [StringLength(80)]
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException();}  
        [JsonIgnore]
        public ICollection<SubjectClass> Class { get => throw new NotImplementedException(); set => throw new NotImplementedException();    }
        public int ClassId { get; set; } 
    }
}
