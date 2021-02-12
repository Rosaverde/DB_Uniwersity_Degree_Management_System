using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Domain.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int UniwersityEmployeeId { get; set; }
        public UniwersityEmployee UniwersityEmployee { get; set; }
        public int DiplomaThesisId { get; set; }
        public DiplomaThesis DiplomaThesis { get; set; }
        public decimal Grade { get; set; }
        public string Comment { get; set; }

    }
}
