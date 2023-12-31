﻿using ClassRoomBackDomain.Interfaces;
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
    [Table("Classes")]
    public class SubjectClass : ISubjectClass
    {
        public SubjectClass()
        {
            Students = new Collection<Student>();
        }
        [Key]
        public int ClassId { get; set; }
        [Required]
        [StringLength(80)]
        public string ClassName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        [ForeignKey(nameof(Student))]
        public int StudentId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<Student> Students { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ClassCode { get ; set; }
    }
}
