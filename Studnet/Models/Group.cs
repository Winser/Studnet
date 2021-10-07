using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Group
    {
        public Group()
        {
            Discussions = new HashSet<Discussions>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Facultyid { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual ICollection<Discussions> Discussions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
