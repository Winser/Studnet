using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class University
    {
        public University()
        {
            Discussions = new HashSet<Discussions>();
            Faculties = new HashSet<Faculty>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Discussions> Discussions { get; set; }
        public virtual ICollection<Faculty> Faculties { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
