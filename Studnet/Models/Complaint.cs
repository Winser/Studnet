using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Complaint
    {
        public string Text { get; set; }
        public int Userid { get; set; }
        public int Fileid { get; set; }

        public virtual File File { get; set; }
        public virtual User User { get; set; }
    }
}
