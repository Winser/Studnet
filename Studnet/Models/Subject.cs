using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Subject
    {
        public Subject()
        {
            FileSubjects = new HashSet<FileSubject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Discusionid { get; set; }

        public virtual Discussions Discussions { get; set; }
        public virtual ICollection<FileSubject> FileSubjects { get; set; }
    }
}
