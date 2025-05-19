using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    /// <summary>
    /// auth: stores metadata about factors
    /// </summary>
    public partial class MfaFactor
    {
        public MfaFactor()
        {
            MfaChallenges = new HashSet<MfaChallenge>();
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string? FriendlyName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Secret { get; set; }
        public string? Phone { get; set; }
        public DateTime? LastChallengedAt { get; set; }
        public string? WebAuthnCredential { get; set; }
        public Guid? WebAuthnAaguid { get; set; }

        public virtual User1 User { get; set; } = null!;
        public virtual ICollection<MfaChallenge> MfaChallenges { get; set; }
    }
}
