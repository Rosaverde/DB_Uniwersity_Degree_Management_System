using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Domain.Models
{
    public class DefenseOfThesis
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int DiplomaThesisId { get; set; }
        public DiplomaThesis DiplomaThesis { get; set; }

        public decimal Grade { get; set; }
        public DateTime DefenseDate { get; set; }
    }
}
