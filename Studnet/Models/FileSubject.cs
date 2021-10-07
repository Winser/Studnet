using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class FileSubject
    {
        public int Fileid { get; set; }
        public int Subjectid { get; set; }

        public virtual File File { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
