using System;
using System.Collections.Generic;

#nullable disable

namespace HEADMEN_EYE.Data
{
    public partial class StudentGroup
    {
        public StudentGroup()
        {
            Students = new HashSet<Student>();
        }

        public string StudentGroup1 { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
