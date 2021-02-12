using DB_System.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Domain.Models
{
    public class UniwersityEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DegreeTitle DegreeTitle { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
