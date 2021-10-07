using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class City
    {
        public City()
        {
            Universities = new HashSet<University>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<University> Universities { get; set; }
    }
}
