using System;
using System.Collections.Generic;

#nullable disable

namespace Studnet.Models
{
    public partial class Post
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int Discusionid { get; set; }
        public int Userid { get; set; }

        public virtual Discussions Discussions { get; set; }
        public virtual User User { get; set; }
    }
}
