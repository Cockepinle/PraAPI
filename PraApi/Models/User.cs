using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class User
    {
        public User()
        {
            Forumposts = new HashSet<Forumpost>();
            Forumreplies = new HashSet<Forumreply>();
            Userquestions = new HashSet<Userquestion>();
            Usertestresults = new HashSet<Usertestresult>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;

        public virtual ICollection<Forumpost> Forumposts { get; set; }
        public virtual ICollection<Forumreply> Forumreplies { get; set; }
        public virtual ICollection<Userquestion> Userquestions { get; set; }
        public virtual ICollection<Usertestresult> Usertestresults { get; set; }
    }
}
