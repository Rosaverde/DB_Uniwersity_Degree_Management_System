using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Domain.Models
{
    public class DiplomaThesis
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public int PromoterId { get; set; }
        public UniwersityEmployee Promoter { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<KeyWord> KeyWords { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
