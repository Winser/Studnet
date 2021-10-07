using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Discussions
    {
        public Discussions()
        {
            Posts = new HashSet<Post>();
            Subjects = new HashSet<Subject>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Universityid { get; set; }
        public int Facultyid { get; set; }
        public int Groupid { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual Group Group { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
