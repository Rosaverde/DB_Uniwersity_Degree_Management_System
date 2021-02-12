using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Domain.Models
{
    public class FieldOfStudies
    {
        public int Id { get; set; }
        public string NameOfField { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
