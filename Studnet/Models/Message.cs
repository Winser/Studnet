using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Message1 { get; set; }
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public int FromId { get; set; }
        public int ToId { get; set; }

        public virtual User From { get; set; }
        public virtual User To { get; set; }
    }
}
