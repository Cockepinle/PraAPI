﻿using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    public partial class Usertestresult
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? TestId { get; set; }
        public int Score { get; set; }
        public DateTime? CompletedAt { get; set; }

        public virtual Languagetest? Test { get; set; }
        public virtual User? User { get; set; }
    }
}
