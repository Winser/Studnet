using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class File
    {
        public File()
        {
            Complaints = new HashSet<Complaint>();
            FileSubjects = new HashSet<FileSubject>();
            Likes = new HashSet<Like>();
        }

        public int Id { get; set; }
        public string Filename { get; set; }
        public int Userid { get; set; }
        public bool Isanon { get; set; }
        public int? Likecount { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual ICollection<FileSubject> FileSubjects { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}
