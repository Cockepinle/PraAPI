using System;
using System.Collections.Generic;

namespace PraApi.Models
{
    /// <summary>
    /// stores metadata for pkce logins
    /// </summary>
    public partial class FlowState
    {
        public FlowState()
        {
            SamlRelayStates = new HashSet<SamlRelayState>();
        }

        public Guid Id { get; set; }
        public Guid? UserId { get; set; }
        public string AuthCode { get; set; } = null!;
        public string CodeChallenge { get; set; } = null!;
        public string ProviderType { get; set; } = null!;
        public string? ProviderAccessToken { get; set; }
        public string? ProviderRefreshToken { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string AuthenticationMethod { get; set; } = null!;
        public DateTime? AuthCodeIssuedAt { get; set; }

        public virtual ICollection<SamlRelayState> SamlRelayStates { get; set; }
    }
}
