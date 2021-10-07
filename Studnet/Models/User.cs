using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class User
    {
        public User()
        {
            Complaints = new HashSet<Complaint>();
            Files = new HashSet<File>();
            Likes = new HashSet<Like>();
            MessageFrom = new HashSet<Message>();
            MessageTo = new HashSet<Message>();
            Posts = new HashSet<Post>();
        }

        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int? Groupid { get; set; }
        public int? Universityid { get; set; }
        public int? Facultyid { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual Group Group { get; set; }
        public virtual University University { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        public virtual ICollection<Message> MessageFrom { get; set; }
        public virtual ICollection<Message> MessageTo { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
