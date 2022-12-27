using System;
using System.Collections.Generic;

#nullable disable

namespace HEADMEN_EYE.Data
{
    public partial class Student
    {
        public long StudentId { get; set; }
        public string NameStdnt { get; set; }
        public string SurnameStdnt { get; set; }
        public string PatronymicStdnt { get; set; }
        public string StudentGroup { get; set; }
        public string Passes { get; set; }

        public virtual StudentGroup StudentGroupNavigation { get; set; }
    }
}
