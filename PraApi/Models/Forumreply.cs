using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Forumreply
    {
        public int Id { get; set; }
        public int? PostId { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }

        public virtual Forumpost? Post { get; set; }
        public virtual User? User { get; set; }
    }
}
