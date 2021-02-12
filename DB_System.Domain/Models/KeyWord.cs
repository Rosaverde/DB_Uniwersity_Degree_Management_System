using System;
using System.Collections.Generic;
using System.Text;

namespace DB_System.Domain.Models
{
    public class KeyWord
    {
        public int Id { get; set; }
        public string Word { get; set; }
        public ICollection<DiplomaThesis> DiplomaTheses { get; set; }
    }
}
