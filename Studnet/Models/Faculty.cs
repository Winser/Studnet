using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            Discussions = new HashSet<Discussions>();
            Groups = new HashSet<Group>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Universityid { get; set; }

        public virtual University University { get; set; }
        public virtual ICollection<Discussions> Discussions { get; set; }
        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
