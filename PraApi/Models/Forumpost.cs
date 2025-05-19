using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Forumpost
    {
        public Forumpost()
        {
            Forumreplies = new HashSet<Forumreply>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual User? User { get; set; }
        public virtual ICollection<Forumreply> Forumreplies { get; set; }
    }
}
