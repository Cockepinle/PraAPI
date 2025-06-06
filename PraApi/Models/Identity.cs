﻿using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    /// <summary>
    /// Auth: Stores identities associated to a user.
    /// </summary>
    public partial class Identity
    {
        public string ProviderId { get; set; } = null!;
        public Guid UserId { get; set; }
        public string IdentityData { get; set; } = null!;
        public string Provider { get; set; } = null!;
        public DateTime? LastSignInAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        /// <summary>
        /// Auth: Email is a generated column that references the optional email property in the identity_data
        /// </summary>
        public string? Email { get; set; }
        public Guid Id { get; set; }

        public virtual User1 User { get; set; } = null!;
    }
}
