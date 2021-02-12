using DB_System.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB_System.Domain.Models
{
    public class Student
    {
        [MinLength(10)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TypeOfStudiesId { get; set; }
        public TypeOfStudies TypeOfStudies { get; set; }
        public ICollection<FieldOfStudies> FieldsOfStudies { get; set; }
        public ICollection<DiplomaThesis> DiplomaTheses { get; set; }

    }
}
